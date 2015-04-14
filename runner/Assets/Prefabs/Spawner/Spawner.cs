using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawner : MonoBehaviour
{

    [SerializeField]
    List<Object> SpawnList;
    public List<GameObject> spawnedObjects;

    void Start()
    {
        spawnedObjects = new List<GameObject>();
    }

    public void spawn()
    {
        int randomRoll = Random.Range(0, calculateMaxRoll());
        Object selectedObject = determineSelectedObject(randomRoll);
        selectedObject.Select();
        escalateUnpicked(selectedObject);
        spawnedObjects.Add(Instantiate(selectedObject.Obj, transform.position, transform.rotation) as GameObject);
    }

    Object determineSelectedObject(int number)
    {
        int i = 0, total = 0;

        while (i < SpawnList.Count)
        {
            total += SpawnList[i].SpawnChance;
            if (number < total) return SpawnList[i];
            i++;
        }
        return SpawnList[i];
    }

    int calculateMaxRoll()
    {
        int i = 0, total = 0;

        while (i < SpawnList.Count)
        {
            total += SpawnList[i].SpawnChance;
            i++;
        }

        return total;
    }

    void escalateUnpicked(Object selectedObject)
    {
        int i = 0;

        while (i < SpawnList.Count)
        {
            Object currentObject = SpawnList[i];
            if (currentObject != selectedObject) currentObject.Escalate();
            i++;
        }
    }
}


