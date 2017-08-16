using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
class CheckDirectory
{
    const string menuTitle = "Tools/CheckDir";
    /// <summary>
    /// Checks directory
    /// </summary>  
    [MenuItem(menuTitle)]
    static void CheckDir()
    {
        var folders = new DirectoryInfo("Assets/Resources/data/editor/00");
        var folderInfos = folders.GetDirectories();
        foreach (DirectoryInfo inf in folderInfos)
            Debug.Log(inf);

        return;

        var path = string.Format("Assets/Resources/data/editor/00/{0}/");
        var info = new DirectoryInfo(path);
        var fileInfo = info.GetFiles("*.xml");
        foreach (FileInfo file in fileInfo)
        {
            var str = file.ToString();
           

        }
     
    }

}

 