using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class Object
{
    public GameObject Obj;
    public int SpawnChance;
    public int Selected;
    public int Escalation;

    public void Select()
    {
        SpawnChance += Selected;
        if (SpawnChance < 0) SpawnChance = 0;
    }

    public void Escalate()
    {
        SpawnChance += Escalation;
    }
}
