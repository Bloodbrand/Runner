using UnityEngine;
using System.Collections;

public class dungeon : MonoBehaviour {
    public spawner roomSpawner;

    public void SpawnRoom()
    {
        destroyRoom();
        roomSpawner.spawn();
    }

    void destroyRoom()
    {
        int length = roomSpawner.spawnedObjects.Count;
        if (length == 0) return;
        GameObject oldRoom = roomSpawner.spawnedObjects[length-1].gameObject;
        Destroy(oldRoom);
    }


}
