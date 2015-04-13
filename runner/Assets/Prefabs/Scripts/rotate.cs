using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    void Update()
    {
        transform.Rotate(new Vector3(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime));
    }
}
