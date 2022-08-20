# Copy Full Path Unity 

![](img.PNG)

Copy the link and paste in Package Manager
```c#
https://github.com/ARtronClassicStudio/com.unity.copyfullpath.git
```

```C#
using System.IO;
using UnityEditor;
using UnityEngine;

internal class CopyFullPath : Editor
{
    [MenuItem("Assets/Copy Full Path &c")]
    internal static void Copy()
    {
        GUIUtility.systemCopyBuffer = Path.GetFullPath(AssetDatabase.GetAssetPath(Selection.activeObject));        
    }
}
```
