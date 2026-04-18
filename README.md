![Workflow Status](https://github.com/mg0x7BE/raylib-fsharp-minimal/actions/workflows/dotnet.yml/badge.svg)
![GitHub repo size](https://img.shields.io/github/repo-size/mg0x7BE/raylib-fsharp-minimal)
![GitHub License](https://img.shields.io/github/license/mg0x7BE/raylib-fsharp-minimal)
![GitHub Created At](https://img.shields.io/github/created-at/mg0x7BE/raylib-fsharp-minimal)
![GitHub forks](https://img.shields.io/github/forks/mg0x7BE/raylib-fsharp-minimal)
![GitHub Repo stars](https://img.shields.io/github/stars/mg0x7BE/raylib-fsharp-minimal)
![Windows](https://img.shields.io/badge/Windows-0078D6?logo=windows&logoColor=white)
![macOS](https://img.shields.io/badge/macOS-000000?logo=apple&logoColor=white)

# Raylib F# Minimal

A minimal example of using [Raylib](https://www.raylib.com/) with F# and [Native AOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/) compilation. Renders a rotating cube - just a clean starting point.

The entire app compiles down to an executable under 1 MB plus `raylib.dll` (~2 MB). No .NET runtime required.

## Build

```
dotnet publish --runtime win-x64 -c Release
dotnet publish --runtime osx-arm64 -c Release
```

## Stack

- **F#** / .NET
- **Raylib-cs** (Raylib C# bindings)

## License

[Unlicense](LICENSE)
