// TimerTray, simple countdown timer
// Copyright (C) 2009 BigPilot, All Rights Reserved
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Media;
using System.Diagnostics;

namespace TimerTray
{
  public partial class TimerForm : Form
  {
    protected bool m_bCanClose = false;
    protected int m_nHours = 0;
    protected int m_nMinutes = 0;
    protected int m_nSeconds = 0;
    protected Font m_DigitsFont = new Font("Microcoft Sans Serif", 44, FontStyle.Bold);
    protected Font m_TextFont = new Font("Microcoft Sans Serif", 24, FontStyle.Bold);
    protected bool m_bCountdownFinished = false;

    public TimerForm()
    {
      InitializeComponent();

      m_timer1.Interval = 1000;

      LoadLastTimerSettingFromRegistry();

      LoadComboBoxValues();

      Reset();

      this.WindowState = FormWindowState.Minimized;
    }

    private void LoadLastTimerSettingFromRegistry()
    {
      RegistryKey hkcu = Registry.CurrentUser;
      RegistryKey key = hkcu.OpenSubKey("SOFTWARE\\TimerTray\\");
      if (key != null)
      {
        m_nHours = (int)key.GetValue("Hours", 0);
        m_nMinutes = (int)key.GetValue("Minutes", 0);
        m_nSeconds = (int)key.GetValue("Seconds", 0);
      }
      else
      {
        hkcu.CreateSubKey("SOFTWARE\\TimerTray\\");
      }
    }

    private void LoadComboBoxValues()
    {
      for (int i = 0; i < 12; i++)
      {
        cbHours.Items.Add(i);
      }
      cbHours.SelectedIndex = m_nHours;

      for (int i = 0; i < 60; i++)
      {
        cbMinutes.Items.Add(i);
      }
      cbMinutes.SelectedIndex = m_nMinutes;

      for (int i = 0; i < 60; i++)
      {
        cbSeconds.Items.Add(i);
      }
      cbSeconds.SelectedIndex = m_nSeconds;
    }

    private void Reset()
    {
      m_timer1.Stop();
      LoadTimerVariablesFromComboBoxes();
      PrepareTimerDisplay();
      UpdateCountDownDisplay();
    }

    private void PrepareTimerDisplay()
    {
      TimerLabel.Font = m_DigitsFont;
      TimerLabel.ForeColor = Color.Black;
    }

    private void PrepareFinishedDisplay()
    {
      TimerLabel.Font = m_TextFont;
      TimerLabel.ForeColor = Color.Red;
    }

    protected void UpdateCountDownDisplay()
    {
      TimerLabel.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", m_nHours, m_nMinutes, m_nSeconds);
      m_notifyIcon1.Text = TimerLabel.Text;
    }

    protected void LoadTimerVariablesFromComboBoxes()
    {
      if ( cbHours.SelectedItem != null )
      {
        m_nHours = int.Parse(cbHours.SelectedItem.ToString());
      }

      if (cbMinutes.SelectedItem != null)
      {
        m_nMinutes = int.Parse(cbMinutes.SelectedItem.ToString());
      }

      if (cbSeconds.SelectedItem != null)
      {
        m_nSeconds = int.Parse(cbSeconds.SelectedItem.ToString());
      }
    }

    private void UpdateButtonCaption()
    {
      if (m_timer1.Enabled)
      {
        StartStopbtn.Text = "Reset";
      }
      else
      {
        StartStopbtn.Text = "Start";
      }
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      ShowTimerForm();
    }

    private void BringFormToFront()
    {
      TopMost = true;
      Show();
      this.WindowState = FormWindowState.Normal;
      Activate();
      TopMost = false;
    }

    private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      //
      // if Windows is shutting down close our timer application
      //
      if (e.CloseReason == CloseReason.WindowsShutDown)
      {
        m_bCanClose = true;
      }

      //
      // if the user presses the system close button we simply hide to the tray
      //
      if (m_bCanClose == false)
      {
        e.Cancel = true;
        this.WindowState = FormWindowState.Minimized;
        m_bCountdownFinished = false;
        Hide();
        return;
      }

      LoadTimerVariablesFromComboBoxes();
      SaveLastTimerSettingsToRegistry();
    }

    private void SaveLastTimerSettingsToRegistry()
    {
      RegistryKey hkcu = Registry.CurrentUser;
      RegistryKey key = hkcu.OpenSubKey("SOFTWARE\\TimerTray\\", true);
      if (key != null)
      {
        key.SetValue("Hours", (int)m_nHours);
        key.SetValue("Minutes", (int)m_nMinutes);
        key.SetValue("Seconds", (int)m_nSeconds);
      }
    }

    private void StartResetBtn_Click(object sender, EventArgs e)
    {
      LoadTimerVariablesFromComboBoxes();
      UpdateCountDownDisplay();
      m_bCountdownFinished = false;

      //
      // if the timer was already at zero don't do anything
      //
      if (m_nHours == 0 && m_nMinutes == 0 && m_nSeconds == 0)
      {
        return;
      }

      if (m_timer1.Enabled == false )
      {
        m_timer1.Start();
      }
      else 
      {
        m_timer1.Stop();
      }

      PrepareTimerDisplay();
      UpdateButtonCaption();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      m_nSeconds--;
      if (m_nSeconds < 0)
      {
        m_nSeconds = 59;
        m_nMinutes--;
        if (m_nMinutes < 0)
        {
          m_nMinutes = 59;
          m_nHours--;
          if (m_nHours < 0)
          {
            m_nHours = 0;
          }
        }
      }

      if (m_nHours == 0 && m_nMinutes == 0 && m_nSeconds == 0)
      {
        BringFormToFront();
        m_timer1.Stop();
        UpdateButtonCaption();
        ShowCountDownFinishedText();
        PlayCountDownFinishedSound();
        LoadTimerVariablesFromComboBoxes();
        m_bCountdownFinished = true;
      }
      else
      {
        UpdateCountDownDisplay();
      }
    }

    private void ShowCountDownFinishedText()
    {
      TimerLabel.Font = m_TextFont;
      TimerLabel.ForeColor = Color.Red;
      TimerLabel.Text = "Countdown finished!";
    }

    private void PlayCountDownFinishedSound()
    {
      try
      {
        SoundPlayer player = new SoundPlayer(Path.GetDirectoryName(Application.ExecutablePath) + @"\Alarm.wav");
        player.Play();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void AboutMenuItem_Click(object sender, EventArgs e)
    {
      About about = new About();
      about.ShowDialog();
    }

    private void ExitMenuItem_Click(object sender, EventArgs e)
    {
      m_bCanClose = true;
      Close();
    }

    private void OpenMenuItem_Click(object sender, EventArgs e)
    {
      ShowTimerForm();
    }

    private void ShowTimerForm()
    {
      BringFormToFront();

      if (m_bCountdownFinished == false)
      {
        PrepareTimerDisplay();
        UpdateCountDownDisplay();
      }
      else
      {
        ShowCountDownFinishedText();
      }
    }

    private void Combo_SelectedIndexChanged(object sender, EventArgs e)
    {
      Reset();
    }
  }
}
