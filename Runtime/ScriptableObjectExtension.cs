// ArchNet · ScriptableObject Extension
// Helpers for assets: get the file name of a ScriptableObject (or any asset) at runtime.
// Docs: https://archnet-plateform.fr/#ScriptableObjectExtension

using System.IO;
using UnityEngine;

namespace ArchNet.Extension
{
    public static class ScriptableObjectExtension
    {
        /// <summary>
        /// File name of the asset, without extension. In the Editor it reads the real file;
        /// in builds it returns the object name, which Unity keeps equal to the file name.
        /// </summary>
        public static string GetAssetFileName(this Object asset)
        {
            if (asset == null) return null;
#if UNITY_EDITOR
            string path = UnityEditor.AssetDatabase.GetAssetPath(asset);
            if (!string.IsNullOrEmpty(path)) return Path.GetFileNameWithoutExtension(path);
#endif
            return asset.name;
        }
    }
}
