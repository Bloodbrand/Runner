using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public int Health;
    public float Speed;
    static float difficulty = 0.1f;

	void Start() {
        InitialiseEnemy();
        //difficulty += 1.1f;
	}

    void InitialiseEnemy(){
    }

	void Update() {
        Move();
	}

    void Move() {
        transform.Translate(-Vector3.forward * Time.deltaTime * (Speed + difficulty));
    }

    void OnTriggerEnter(Collider other) {
        Die();
    }

    void OnBecameInvisible() {
        Die();
    }

    void Die() {
        Destroy(gameObject);
    }
}
