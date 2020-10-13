using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



    [CustomEditor(typeof(Cube))]

public class cubeeditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cube cube = (Cube)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Generate Color"))
        {
            cube.GenerateColor();
        }

        if (GUILayout.Button("Reset"))
        {
            cube.Reset();
        }
        GUILayout.EndHorizontal();

        if (GUILayout.Button("Applause"))
        {
            cube.stopAudio();
            cube.Applause();
        }

        if (GUILayout.Button("Boo"))
        {
            cube.stopAudio();
            cube.Boo();
        }
    }
}
