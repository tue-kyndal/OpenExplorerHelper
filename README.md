# OpenExplorerHelper

OpenExplorerHelper is a small Windows utility that allows web
applications or HTML pages to open Windows Explorer directly to a
specified folder using a custom URL protocol.

It enables links like:

openexplorer://192.168.xxx/server/case/28600

And also supports mounted drives such as:

openexplorer:Z:/case/28600

------------------------------------------------------------------------

## Features

-   Opens Windows Explorer from a browser link
-   Supports UNC network paths
-   Supports mounted drives (e.g. Z:, Y:, etc.)
-   Lightweight single-file executable
-   No external runtime required (self-contained build)

------------------------------------------------------------------------

## Supported Link Formats

### UNC Path

openexplorer://SERVER/Share/Folder/Subfolder

Example:

openexplorer://192.168.1.xxx/server/case/28600

### Mounted Drive

openexplorer:Z:/case/28600

Works with any mapped drive letter available on the client machine.

------------------------------------------------------------------------

## Build

Compile the project using:

dotnet publish -c Release -r win-x64 --self-contained true
/p:PublishSingleFile=true

The executable will be generated in:

bin/Release/net10.0/win-x64/publish/

------------------------------------------------------------------------

## Installation

1.  Copy the generated .exe file to:

    C:`\Program `{=tex}Files`\OpenExplorerHelper`{=tex}\

2.  Register the protocol in Windows using this registry file:

Windows Registry Editor Version 5.00

\[HKEY_CLASSES_ROOT`\openexplorer`{=tex}\] @="URL:Open Explorer Helper"
"URL Protocol"=""

\[HKEY_CLASSES_ROOT`\openexplorer`{=tex}`\shell`{=tex}\]

\[HKEY_CLASSES_ROOT`\openexplorer`{=tex}`\shell`{=tex}`\open`{=tex}\]

\[HKEY_CLASSES_ROOT`\openexplorer`{=tex}`\shell`{=tex}`\open`{=tex}`\command`{=tex}\]
@="\"C:\\Program Files\\OpenExplorerHelper\\OpenExplorerHelper.exe\"
\"%1\""

After this, clicking openexplorer: links in a browser will launch
Windows Explorer.

------------------------------------------------------------------------

## Notes

-   The application must be installed locally on each client machine.
-   Explorer opening speed depends on network performance.
-   The mapped drive (e.g. Z:) must exist on the client system.
