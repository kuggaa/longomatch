; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{473D1B4B-6BE6-4AAF-BDD0-F7C422A27FBD}
AppName=LongoMatch
AppVerName=LongoMatch 0.16.1
AppPublisher=Ylatuya
AppPublisherURL=http://www.longomatch.ylatuya.es
AppSupportURL=http://www.longomatch.ylatuya.es
AppUpdatesURL=http://www.longomatch.ylatuya.es
DefaultDirName={pf}\LongoMatch-0.16
DefaultGroupName=LongoMatch
LicenseFile=.\COPYING.TXT
SetupIconFile=..\LongoMatch\images\minilogo.ico
OutputDir=.
OutputBaseFilename=.\LongoMatch-0.16.1
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "basque"; MessagesFile: "compiler:Languages\Basque.isl"
Name: "catalan"; MessagesFile: "compiler:Languages\Catalan.isl"
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: ".\dist\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\LongoMatch-0.15"; Filename: "{app}\bin\LongoMatch.exe" ;WorkingDir: "{app}\bin"
Name: "{group}\Theme Selector"; Filename: "{app}\bin\ThemeSelector.exe" ;WorkingDir: "{app}\bin"
Name: "{group}\X-Installation Checks (Use only to report installation errors)"; Filename: "{app}\bin\rxvt.exe"; Parameters:"-e ./sh checks.sh" ; WorkingDir: "{app}\bin" ; IconFileName: "{app}\share\chronojump\images\chronojump_icon.ico"
Name: "{commondesktop}\LongoMatch"; Filename: "{app}\bin\LongoMatch.exe"; WorkingDir: "{app}\bin"; Tasks: desktopicon

[Run]
Filename: "{app}\bin\LongoMatch.exe"; WorkingDir: "{app}\bin";Description: "{cm:LaunchProgram,LongoMatch}"; Flags: nowait postinstall skipifsilent

[InstallDelete] 
Type: filesandordirs; Name:"{userdocs}\..\.gstreamer-0.10"
Type: filesandordirs; Name:"{app}\*"
