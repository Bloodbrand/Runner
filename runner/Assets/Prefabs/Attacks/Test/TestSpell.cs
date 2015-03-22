using UnityEngine;
using System.Collections;

public class TestSpell : movingGameObject
{
    void Start()
    {
        MoveDirection = new Vector3(0, 0, 1);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy();
    }
}
