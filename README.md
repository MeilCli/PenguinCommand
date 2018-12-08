# PenguinCommand
Sample of .NET Core Global Tools.

## Usage
1. Clone this repository
2. Open directory `/PenguinCommand.NETCore` in CLI
3. Run `dotnet pack`
4. Install tools, run `dotnet tool install --global --add-source bin\Debug PenguinCommand.NETCore`
5. Show help, run `penguin -h`

## Debug tools
- No arguments: `dotnet run`
- With arguments: `dotnet run -- list 3 -l`
   - Separate `dotnet` command and `penguin` command arguments with `--` 

## License
This repository under the MIT License.

Using Library:
- [CommandLineUtils](https://github.com/natemcmaster/CommandLineUtils)
  - Published by [Apache License 2.0](https://github.com/natemcmaster/CommandLineUtils/blob/master/LICENSE.txt)