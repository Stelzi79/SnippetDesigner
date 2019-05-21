$vsixPath = ".\src\SnippetDesigner\bin\**\*.vsix";
#param (
#  [string]$vsixPath = ""
# )

(new-object Net.WebClient).DownloadString("https://raw.github.com/madskristensen/ExtensionScripts/master/AppVeyor/vsix.ps1") | Invoke-Expression

$env:APPVEYOR_REPO_PROVIDER = "https://github.com/Stelzi79/SnippetDesigner"

Vsix-PublishToGallery $vsixPath 