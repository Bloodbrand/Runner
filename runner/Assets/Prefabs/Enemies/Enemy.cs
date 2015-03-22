using UnityEngine;
using System.Collections;

public class Enemy : movingGameObject
{
    public int Health;
    public Transform Explosion;

    void Start()
    {
        InitialiseEnemy();
    }

    void InitialiseEnemy()
    {
        MoveDirection = new Vector3(0, 0, -1);
    }

    void OnTriggerEnter(Collider other)
    {
        Die();
    }

    void Explode()
    {
        Instantiate(Explosion, transform.position, transform.rotation);
    }

    void Die()
    {
        Explode();
        Destroy();
    }

}
