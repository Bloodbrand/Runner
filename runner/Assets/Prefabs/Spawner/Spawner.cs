using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

    public List<Transform> Enemies;
    public bool spawning = true;
    [SerializeField] float spawnRate;    
    GameObject[] spawnPoints;

	void Start() {
        FindSpawnPoints();
        StartCoroutine(SpawnEnemies());
	}

    void FindSpawnPoints() {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
    }

    IEnumerator SpawnEnemies() {
        while (spawning){
            int random = Random.Range(0, spawnPoints.Length);
            Instantiate(Enemies[0], spawnPoints[random].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
