using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBezierCurve : MonoBehaviour
{
    [SerializeField]
    PathCreation.PathCreator CurrentPath;

    [SerializeField]
    GameObject TempPrefab;

    [SerializeField]
    List<GameObject> PlacedObjectsList = new List<GameObject>();

    [SerializeField]
    List<Vector2> SavedPositionForPlacedObjects = new List<Vector2>();

    [Sirenix.OdinInspector.Button]
    void PlaceButtonsWithGivenAmount(int Amount)
    {
        if (PlacedObjectsList.Count > 0)
        {
            for (int i = 0; i < PlacedObjectsList.Count; i++)
            {
                if (PlacedObjectsList[i] != null)
                {
                    DestroyImmediate(PlacedObjectsList[i]);
                }
            }
        }

        PlacedObjectsList.Clear();
        SavedPositionForPlacedObjects.Clear();

        float pathLength = CurrentPath.path.length;
        float distanceForOneButton = pathLength / Amount;

        for (int i = 0; i < Amount; i++)
        {
            GameObject InstantiatedObj = Instantiate(TempPrefab, transform.position, Quaternion.identity, transform);
            InstantiatedObj.transform.position = CurrentPath.path.GetPointAtDistance(distanceForOneButton * i);
            SavedPositionForPlacedObjects.Add(InstantiatedObj.transform.position);
            PlacedObjectsList.Add(InstantiatedObj);
        }
    }
}
