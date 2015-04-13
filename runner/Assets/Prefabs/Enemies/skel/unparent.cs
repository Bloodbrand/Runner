using UnityEngine;
using System.Collections;

public class unparent : MonoBehaviour
{
    public void unparentMesh()
    {
        foreach (Transform child in transform)
        {
            Rigidbody rb = child.gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "bone")
            unparentMesh();

    }

    void OnCollisionEnter(Collision collision)
    {
        unparentMesh();
    }
}
