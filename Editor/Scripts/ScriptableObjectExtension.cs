using System.IO;
using UnityEditor;

namespace ArchNet.Extension.ScriptableObject
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [SCRIPTABLE OBJECT] Scriptable object extension manager
    /// author : LOUIS PAKEL
    /// </summary>
    public static class ScriptableObjectExtension
    {
        /// <summary>
        /// Description : Get the object name of a instance
        /// </summary>
        /// <param name="pInstanceId"></param>
        /// <returns></returns>
        public static string GetScriptablePathName(int pInstanceId)
        {
            string assetPath = AssetDatabase.GetAssetPath(pInstanceId);

            string lResult = Path.GetFileNameWithoutExtension(assetPath);

            return lResult;
        }
    }
}
