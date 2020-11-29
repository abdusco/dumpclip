![](./dumpclip.png)

# dumpclip

Dump clipboard contents as JSON to console.

Download binary from [Releases](https://github.com/abdusco/dumpclip/releases)

## Usage
### Listen to clipboard changes

- Run the program with `--listen` flag

  ```powershell
  dumpclip --listen
  ```
  
  As you copy some content into clipboard, clipboard contents will be dumped as JSON.

  ```json
  {"text":"ClipboardChanged"}
  {"text":"monitor"}
  {"files":["D:\\_dev\\web\\abdus.dev\\src\\projects\\askme\\askme.gif","D:\\_dev\\web\\abdus.dev\\src\\projects\\askme\\askme.md"]}
  ```
  
### One-off
- Copy some text then run
  ```powershell
  dumpclip.exe
  ```
  The program outputs the clipboard contents then exits.
  ```json
  {"text":"Dump clipboard contents as JSON to console."}
  ```
  If you've copied some files:
  ```json
  {"files":["D:\\_dev\\windows\\dumpclipboard\\DumpClipboard\\bin\\Release\\dumpclip.exe","D:\\_dev\\windows\\dumpclipboard\\DumpClipboard\\bin\\Release\\dumpclip.pdb"]}
  ```
  
## Changelog

### v1.1.0
- Add support for listening to changes

### v1.0.0
- Initial release