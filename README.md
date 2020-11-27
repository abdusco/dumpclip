# dumpclip

Dump clipboard contents as JSON to console.

Download binary from [Releases](https://github.com/abdusco/dumpclip/releases)

## Usage

- Copy some text then run
    ```powershell
    dumpclip.exe
    ```
    
    output: 
    
    ```json
    {"text":"Dump clipboard contents as JSON to console."}
    ```
- Copy some files then run
    ```powershell
    dumpclip.exe
    ```
    
    output:
  
    ```json
    {"files":["D:\\_dev\\windows\\dumpclipboard\\DumpClipboard\\bin\\Release\\dumpclip.exe","D:\\_dev\\windows\\dumpclipboard\\DumpClipboard\\bin\\Release\\dumpclip.pdb"]}
    ```