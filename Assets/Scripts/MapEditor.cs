using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MapEditor
{
    [MenuItem("Assets/Create/Map Patterns")]
    public static void CreatePatterns()
    {
        MapPatternScriptableObjet Map = ScriptableObject.CreateInstance<MapPatternScriptableObjet>();
        AssetDatabase.CreateAsset(Map, "Assets/ScriptableObjects/Map.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = Map;
    }
}
