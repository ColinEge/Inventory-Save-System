using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ScriptableObjectLocator))]
public class ScriptableObjectLocatorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ScriptableObjectLocator script = (ScriptableObjectLocator)target;
        if (GUILayout.Button("Find InventoryItems"))
        {
            script.AddAllScriptableObjectsContainingUIDs<InventorySystem.InventoryItem>();
            Repaint();
        }

        if (GUILayout.Button("Find Ingredients"))
        {
            script.AddAllScriptableObjectsContainingUIDs<Ingredient>();
            Repaint();
        }

        if (GUILayout.Button("Clear All Scriptable Objects"))
        {
            script.ClearAllScriptableObjects();
        }
    }
}
