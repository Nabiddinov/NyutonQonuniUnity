// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.

using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(MediaPlayerImage), true)]
public class MediaPlayerImageEditor : ImageEditor
{
    SerializedProperty m_ButtonType;

    protected override void OnEnable()
    {
        base.OnEnable();

        m_ButtonType = serializedObject.FindProperty("m_ButtonType");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.PropertyField(m_ButtonType);
        serializedObject.ApplyModifiedProperties();
    }
}
