<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · ScriptableObject Extension

Helpers for assets: get the file name of a ScriptableObject (or any asset), in the Editor and in builds.

- Unity **6000.0** or newer · No dependency.
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/ScriptableObjectExtension.git
```

## Use

```csharp
using ArchNet.Extension;

string file = mySettings.GetAssetFileName();
```

## License

MIT, see [LICENSE.md](LICENSE.md).
