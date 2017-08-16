using UnityEditor;
using UnityEngine;
using System.Collections;

// Simple Editor Script that fills a bar in the given seconds.
public class EditorUtilityDisplayProgressBar : EditorWindow
{
    public float secs = 10f;
    public float startVal = 0f;
    public float progress = 0f;
    [MenuItem("Examples/Progress Bar Usage")]
    static void Init()
    {
        UnityEditor.EditorWindow window = GetWindow(typeof(EditorUtilityDisplayProgressBar));
        window.Show();
    }

    void OnGUI()
    {
        secs = EditorGUILayout.FloatField("Time to wait:", secs);
        if (GUILayout.Button("Display bar"))
        {
            if (secs < 1)
            {
                Debug.LogError("Seconds should be bigger than 1");
                return;
            }
            startVal = (float)EditorApplication.timeSinceStartup;
        }
        if (progress < secs)
            EditorUtility.DisplayProgressBar("Simple Progress Bar", "Shows a progress bar for the given seconds", progress / secs);
        else
            EditorUtility.ClearProgressBar();
        progress = (float)(EditorApplication.timeSinceStartup - startVal);
    }

    void OnInspectorUpdate()
    {
        Repaint();
    }
    
}