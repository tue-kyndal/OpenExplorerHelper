# OpenExplorerHelper

**OpenExplorerHelper** is a small Windows utility that allows you to open network folders using a custom URL protocol (`openexplorer://`). This is useful for quickly linking to folders from HTML pages, documentation, or other applications.

---

## Features

- Opens UNC network paths in Windows Explorer.
- Works with links like `openexplorer://192.168.15.133/Filserver2016/sager/28600-28799/28739`.
- Can be used in **Edge, Edge IE mode** **Internet Explorer** or any other browser.
- Minimal setup: just install the EXE and registry file.

---

## Files in this repository

- `OpenExplorerHelper.exe` – the compiled program that handles the protocol.
- `OpenExplorerHelper.reg` – registry file to register the `openexplorer://` protocol.
- `README.md` – this file.

---

## Installation

1. **Copy the OpenExplorerHelper.EXE to your machine**:

   Place the EXE somewhere permanent, for example:

C:\Program Files\OpenExplorerHelper\OpenExplorerHelper.exe


2. **Install the registry entry**:

- Double-click the `OpenExplorerHelper.reg` file.
- Windows will ask: *“Do you want to allow this app to make changes?”* Click **Yes**.
- This registers the `openexplorer://` protocol to launch the EXE.

3. **Verify installation**:

- Open Run (`Win + R`) and type:

  ```
  openexplorer://192.168.1.xx/Filserver/sager/28600-28799/28739
  ```

- Windows Explorer should open the corresponding network folder.

---

## Usage with HTML

You can create simple HTML pages with clickable links to network folders. Example:

```html
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>OpenExplorerHelper Test</title>
</head>
<body>
<h1>Test OpenExplorerHelper</h1>
<ul>
 <li><a href="openexplorer://192.168.1.xx/Filserver/case/28600-28799/28739">Case 28739</a></li>
 <li><a href="openexplorer://192.168.1.xx/Filserver/case/28600-28799/28740">Case 28740</a></li>
</ul>
<p>Open in Edge (IE mode) or Internet Explorer.</p>
</body>
</html>

Clicking a link will launch the EXE and open the corresponding folder.
