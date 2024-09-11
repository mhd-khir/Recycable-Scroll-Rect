using System.Collections.Generic;
using UnityEngine;
using PolyAndCode.UI;

/// <summary>
/// Demo controller class for Recyclable Scroll Rect. 
/// A controller class is responsible for providing the scroll rect with datasource. Any class can be a controller class. 
/// The only requirement is to inherit from IRecyclableScrollRectDataSource and implement the interface methods
/// </summary>

//Dummy Data model for demostraion


[System.Serializable]
public class AnimatedObjects
{
    public Vector2 Pos;
    public Vector2 scale;
    public Sprite sp;
}

[System.Serializable]
public class PatternInfo
{
    public int ID;
    //public List<Vector2> Positons = new List<Vector2>();
    //public List<AnimatedObjects> AnimatedObjs = new List<AnimatedObjects>();
    public PatternInfo(int id/*, List<Vector2> positions*/)
    {
        //Positons = positions;
        ID = id;
    }
}

public class RecyclableScrollerDemo : MonoBehaviour, IRecyclableScrollRectDataSource
{
    [SerializeField]
    RecyclableScrollRect _recyclableScrollRect;

    [SerializeField]
    private int _dataLength;
    [SerializeField]
    private Sprite[] BG;
    //Dummy data List
    private List<PatternInfo> patternsList = new List<PatternInfo>();

    //Recyclable scroll rect's data source must be assigned in Awake.
    private void Awake()
    {
        InitData();
        _recyclableScrollRect.DataSource = this;
    }

    //Initialising _contactList with dummy data 
    private void InitData()
    {
        if (patternsList != null) patternsList.Clear();

        for (int i = 0; i < _dataLength; i++)
        {
            PatternInfo obj = new PatternInfo(i);
            patternsList.Add(obj);
        }
    }

    #region DATA-SOURCE

    /// <summary>
    /// Data source method. return the list length.
    /// </summary>
    public int GetItemCount()
    {
        return patternsList.Count;
    }

    /// <summary>
    /// Data source method. Called for a cell every time it is recycled.
    /// Implement this method to do the necessary cell configuration.
    /// </summary>
    public void SetCell(ICell cell, int index)
    {
        //Casting to the implemented Cell
        var item = cell as DemoCell;
        item.ConfigureCell(patternsList[index], index, BG[index]);
    }

    #endregion
}