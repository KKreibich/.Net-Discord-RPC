; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Custom Discord RPC"
#define MyAppVersion "1.0"
#define MyAppPublisher "Kilian Kreibich"
#define MyAppURL "https://github.com/KKreibich/.Net-Discord-RPC/releases"
#define MyAppExeName "discord_custom_rpc.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{FDDCA822-7A67-49CC-AAD9-118170F5715D}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\CustomDiscordRPC
DisableProgramGroupPage=yes
LicenseFile=C:\Users\Kilian\source\repos\discord_custom_rpc\discord_custom_rpc\LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=C:\Users\Kilian\Desktop\customrpc
OutputBaseFilename=cdrpc_v1.0_setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Kilian\Desktop\customrpc\cdrpc_1.0\discord_custom_rpc.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Kilian\Desktop\customrpc\cdrpc_1.0\DiscordRPC.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Kilian\Desktop\customrpc\cdrpc_1.0\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
