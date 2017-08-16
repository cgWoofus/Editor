using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Loader : EditorWindow
{
    static void Init()
    {
        UnityEditor.EditorWindow window = GetWindow(typeof(EditorUtilityDisplayProgressBar));
        window.Show();
    }
    float _cur=0, _max=0;

    public void progress(float _val, float _mx)
    {
        _cur = _val;
        _max = _mx;
        Repaint();
    }

    private void OnGUI()
    {
        
   //     EditorUtility.ClearProgressBar();
        EditorUtility.DisplayProgressBar("Simple Progress Bar", "Shows a progress bar for the given seconds", _cur / _max);
        if (_cur >= 1)
            EditorUtility.ClearProgressBar();
        Repaint();
    }


    void OnInspectorUpdate()
    {
        Repaint();
    }

}
