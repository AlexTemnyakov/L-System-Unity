using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LSystem
{
    [CustomEditor(typeof(LSystemObject))]
    public class LSystemObjectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            LSystemObject __target = (LSystemObject)target;

            if (GUILayout.Button("Grow"))
            {
                __target.Grow();
            }

            if (GUILayout.Button("Clear"))
            {
                __target.Clear();
            }
        }
    }
}
