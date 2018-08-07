; TimerTray setup script

[Setup]
AppName=TimerTray
AppVerName=TimerTray Version 1.3
DefaultDirName={pf}\TimerTray
DefaultGroupName=TimerTray
UninstallDisplayIcon={app}\TimerTray.exe
WizardImageFile=stopwatch.bmp

[Files]
Source: "TimerTray.exe"; DestDir: "{app}"
Source: "Alarm.wav"; DestDir: "{app}"
Source: "License.txt"; DestDir: "{app}"

[Icons]
Name: "{group}\TimerTray"; Filename: "{app}\TimerTray.exe"

[Registry]
Root: HKCU; Subkey: "Software\Microsoft\Windows\CurrentVersion\Run"; Flags: uninsdeletekey; ValueType: string; ValueName: "TimerTray"; ValueData: "{app}\TimerTray.exe"

[Run]
Filename: "{app}\TimerTray.exe"; Flags: nowait runasoriginaluser


