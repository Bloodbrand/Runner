using UnityEngine;
using System.Collections;

public class movingGameObject : MonoBehaviour {
    public float Speed;
    protected Vector3 MoveDirection;

    public virtual void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        transform.Translate(MoveDirection * Time.deltaTime * Speed);
    }

    public virtual void OnBecameInvisible()
    {
        Destroy();
    }

    public virtual void Destroy()
    {
        Destroy(gameObject);
    }

}
