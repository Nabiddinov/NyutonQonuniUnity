
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ftLightmapsStorage))]
public class ftLightmapsStorageInspector : UnityEditor.Editor
{
    static bool showDebug = false;

    public override void OnInspectorGUI()
    {

        EditorGUILayout.LabelField("This object stores Bakery lightmapping data");

        if (showDebug)
        {
            if (GUILayout.Button("Hide debug info")) showDebug = false;
            DrawDefaultInspector();
        }
        else
        {
            if (GUILayout.Button("Show debug info")) showDebug = true;
        }
    }
}

