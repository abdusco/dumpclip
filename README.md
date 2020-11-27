# dumpclip

Dump clipboard contents as JSON to console.

## Usage

- Copy some text
    ```powershell
    dumpclip.exe
    ```
    
    output: 
    
    ```json
    {"text":"Dump clipboard contents as JSON to console."}
    ```
- Copy some files
    ```powershell
    dumpclip.exe
    ```
    
    output:
  
    ```json
    {"files":["D:\\_dev\\windows\\dumpclipboard\\DumpClipboard\\bin\\Release\\dumpclip.exe","D:\\_dev\\windows\\dumpclipboard\\DumpClipboard\\bin\\Release\\dumpclip.pdb"]}
    ```