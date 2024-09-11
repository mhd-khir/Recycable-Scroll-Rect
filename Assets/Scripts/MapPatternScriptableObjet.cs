using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
public class MapPatternScriptableObjet : ScriptableObject
{
    public List<PatternInfo> patternInfos = new List<PatternInfo>();
}

