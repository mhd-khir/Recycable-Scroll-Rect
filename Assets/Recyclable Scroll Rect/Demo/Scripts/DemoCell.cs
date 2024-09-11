using UnityEngine;
using UnityEngine.UI;
using PolyAndCode.UI;
using System.Collections.Generic;
using System.Collections;
using Sirenix.OdinInspector;
//Cell class for demo. A cell in Recyclable Scroll Rect must have a cell class inheriting from ICell.
//The class is required to configure the cell(updating UI elements etc) according to the data during recycling of cells.
//The configuration of a cell is done through the DataSource SetCellData method.
//Check RecyclableScrollerDemo class
public class DemoCell : MonoBehaviour, ICell
{
    //UI
    public Button[] patternLvlBtns;

    //Model
    private PatternInfo _contactInfo;
    private int _cellIndex;

    
    //public button, iamge 
    private void Start()
    {
        //Can also be done in the inspector
        //GetComponent<Button>().onClick.AddListener(ButtonListener);
        
    }

    //This is called from the SetCell method in DataSource
    public void ConfigureCell(PatternInfo contactInfo,int cellIndex,Sprite sp)
    {
        _cellIndex = cellIndex;
        _contactInfo = contactInfo;
        GetComponent<Image>().sprite = sp;
        /*foreach (Button btn in patternLvlBtns)
            btn.gameObject.SetActive(false);
        if(PlayerPrefs.HasKey("pattern"+ cellIndex))
        {
            string[] levelBtns = PlayerPrefs.GetString("pattern" + cellIndex).Split('-');
            for(int i=0;i<levelBtns.Length;i++)
            {
                string[] xy = levelBtns[i].Split(',');
                float x = (float)System.Convert.ToDouble(xy[0]);
                float y = (float)System.Convert.ToDouble(xy[1]);
                patternLvlBtns[i].transform.position = new Vector3(x, y, 0);
            }
        }*/
        // buttons, others ..
    }
    List<Vector2> positions;
    public int id;
    public MapPatternScriptableObjet Map;
    [Button]
    public void SaveButtonsPositions(int id)
    {
        /*positions = new List<Vector2>();
        float x = 0;
        float y = 0;
        
        for (int i = 0; i < patternLvlBtns.Length; i++)
        {
            if(patternLvlBtns[i].IsActive())
            {
                Vector3 vector = patternLvlBtns[i].transform.position;
                x = vector.x;
                y = vector.y;
                positions.Add(new Vector2(x, y));
            }
        }

        PatternInfo info = Map.patternInfos.Find(x => x.ID == id);
        if (info != null)
            Map.patternInfos.Remove(info);
        Map.patternInfos.Add(new PatternInfo(id,positions));
        */
        //PlayerPrefs.SetString("pattern" + id, patterns);
        // IO --> File // 
    }
}
