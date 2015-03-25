using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
    public float time;
	void Start () {
        Destroy(gameObject, time);
	}
	
}
