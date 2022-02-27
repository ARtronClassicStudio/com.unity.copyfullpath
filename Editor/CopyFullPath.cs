using System.IO;
using UnityEditor;
using UnityEngine;

internal class Copy FullPath : Editor
{
[MenuItem("Assets/Copy Full Path")]
internal static void Copy()
{
GUIUtility.systemCopyBuffer = Path.GetFullPath(AssetDatabase.GetAssetPath(Selection.activeObject));
}
}
