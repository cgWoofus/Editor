using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
class ContextMenus
{
    const string menuTitle = "Tools/Create Level from XML";
    const string prefabPath = "Assets/Resources/prefab/_objects/{0}.prefab";
    /// <summary>
    /// Creates a prefab from the selected game object.
    /// </summary>
    /// 


    [MenuItem("Assets/CreateObjectPrefab",false,0)]
     static void init()
    {
        var _obj = Selection.activeObject;
        PrefabUtility.CreateEmptyPrefab(string.Format(prefabPath,_obj.name));
    }
    

}

 