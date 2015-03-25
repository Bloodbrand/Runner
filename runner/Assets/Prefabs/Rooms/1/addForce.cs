using UnityEngine;
using System.Collections;

public class addForce : MonoBehaviour {
    Ray ray;
    RaycastHit hit;
    [SerializeField] Transform explosion;
	
    void Update()
    {
        GetClick();
	}

    void GetClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                AddExplosion(hit.point);
            }
        }	
    }

    void AddExplosion(Vector3 position)
    {
        Instantiate(explosion, position, Quaternion.identity);
        Collider[] colliders = Physics.OverlapSphere(position, 100);
        foreach (Collider hit in colliders) {
            if (hit && hit.GetComponent<Rigidbody>())
                hit.GetComponent<Rigidbody>().AddExplosionForce(2000, position, 25, 3.0F);
            
        }    
    }
}
