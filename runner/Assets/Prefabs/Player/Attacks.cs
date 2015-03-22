using UnityEngine;
using System.Collections;

public class Attacks : MonoBehaviour {
    public Transform spell1;

    GameObject[] attackPoints;

    void Start()
    {
        FindSpawnPoints();
    }

    void FindSpawnPoints()
    {
        attackPoints = GameObject.FindGameObjectsWithTag("attackPoint");
    }
	
	void Update () {
        if (Input.GetKeyDown("q")) Instantiate(spell1, attackPoints[0].transform.position, Quaternion.identity);
        if (Input.GetKeyDown("w")) Instantiate(spell1, attackPoints[1].transform.position, Quaternion.identity);
        if (Input.GetKeyDown("e")) Instantiate(spell1, attackPoints[2].transform.position, Quaternion.identity);
	}
}
