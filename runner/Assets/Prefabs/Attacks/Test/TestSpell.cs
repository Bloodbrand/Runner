using UnityEngine;
using System.Collections;

public class TestSpell : MonoBehaviour {

    float speed = 30.0f;

    void Update(){
        Move();
    }

    void Move() {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void OnBecameInvisible(){
        Die();
    }

    void Die(){
        Destroy(gameObject);
    }
}
