namespace TimerTray
{
  partial class TimerForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
      this.m_notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.m_contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.TimerLabel = new System.Windows.Forms.Label();
      this.cbHours = new System.Windows.Forms.ComboBox();
      this.cbMinutes = new System.Windows.Forms.ComboBox();
      this.cbSeconds = new System.Windows.Forms.ComboBox();
      this.StartStopbtn = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.m_timer1 = new System.Windows.Forms.Timer(this.components);
      this.m_contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_notifyIcon1
      // 
      this.m_notifyIcon1.ContextMenuStrip = this.m_contextMenuStrip1;
      this.m_notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("m_notifyIcon1.Icon")));
      this.m_notifyIcon1.Text = "TimerTray";
      this.m_notifyIcon1.Visible = true;
      this.m_notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
      // 
      // m_contextMenuStrip1
      // 
      this.m_contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.AboutMenuItem,
            this.ExitMenuItem});
      this.m_contextMenuStrip1.Name = "contextMenuStrip1";
      this.m_contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
      // 
      // OpenMenuItem
      // 
      this.OpenMenuItem.Name = "OpenMenuItem";
      this.OpenMenuItem.Size = new System.Drawing.Size(165, 22);
      this.OpenMenuItem.Text = "Open";
      this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
      // 
      // AboutMenuItem
      // 
      this.AboutMenuItem.Name = "AboutMenuItem";
      this.AboutMenuItem.Size = new System.Drawing.Size(165, 22);
      this.AboutMenuItem.Text = "About TimerTray";
      this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
      // 
      // ExitMenuItem
      // 
      this.ExitMenuItem.Name = "ExitMenuItem";
      this.ExitMenuItem.Size = new System.Drawing.Size(165, 22);
      this.ExitMenuItem.Text = "Exit";
      this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
      // 
      // TimerLabel
      // 
      this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TimerLabel.Location = new System.Drawing.Point(7, 9);
      this.TimerLabel.Name = "TimerLabel";
      this.TimerLabel.Size = new System.Drawing.Size(274, 164);
      this.TimerLabel.TabIndex = 0;
      this.TimerLabel.Text = "00:00:00";
      this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.TimerLabel.UseMnemonic = false;
      // 
      // cbHours
      // 
      this.cbHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbHours.FormattingEnabled = true;
      this.cbHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
      this.cbHours.Location = new System.Drawing.Point(13, 187);
      this.cbHours.Name = "cbHours";
      this.cbHours.Size = new System.Drawing.Size(55, 21);
      this.cbHours.TabIndex = 1;
      this.cbHours.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
      // 
      // cbMinutes
      // 
      this.cbMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbMinutes.FormattingEnabled = true;
      this.cbMinutes.Location = new System.Drawing.Point(74, 187);
      this.cbMinutes.Name = "cbMinutes";
      this.cbMinutes.Size = new System.Drawing.Size(54, 21);
      this.cbMinutes.TabIndex = 2;
      this.cbMinutes.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
      // 
      // cbSeconds
      // 
      this.cbSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cbSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSeconds.FormattingEnabled = true;
      this.cbSeconds.Location = new System.Drawing.Point(134, 187);
      this.cbSeconds.Name = "cbSeconds";
      this.cbSeconds.Size = new System.Drawing.Size(60, 21);
      this.cbSeconds.TabIndex = 3;
      this.cbSeconds.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
      // 
      // StartStopbtn
      // 
      this.StartStopbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.StartStopbtn.Location = new System.Drawing.Point(200, 179);
      this.StartStopbtn.Name = "StartStopbtn";
      this.StartStopbtn.Size = new System.Drawing.Size(81, 34);
      this.StartStopbtn.TabIndex = 4;
      this.StartStopbtn.Text = "Start";
      this.StartStopbtn.UseVisualStyleBackColor = true;
      this.StartStopbtn.Click += new System.EventHandler(this.StartResetBtn_Click);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 211);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Hours";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(71, 210);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Minutes";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(131, 210);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Seconds";
      // 
      // m_timer1
      // 
      this.m_timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // TimerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(289, 228);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.StartStopbtn);
      this.Controls.Add(this.cbSeconds);
      this.Controls.Add(this.cbMinutes);
      this.Controls.Add(this.cbHours);
      this.Controls.Add(this.TimerLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TimerForm";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "TimerTray";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimerForm_FormClosing);
      this.m_contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NotifyIcon m_notifyIcon1;
    private System.Windows.Forms.Label TimerLabel;
    private System.Windows.Forms.ComboBox cbHours;
    private System.Windows.Forms.ComboBox cbMinutes;
    private System.Windows.Forms.ComboBox cbSeconds;
    private System.Windows.Forms.Button StartStopbtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Timer m_timer1;
    private System.Windows.Forms.ContextMenuStrip m_contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
  }
}

