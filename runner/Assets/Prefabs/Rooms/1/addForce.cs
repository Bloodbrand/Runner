using UnityEngine;
using System.Collections;

public class addForce : MonoBehaviour {
    Ray ray;
    RaycastHit hit;
    [SerializeField] Transform explosion;
    public float force;
    public float radius;
	
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
                //AddExplosion(hit.point);
            }
        }	
    }

    void AddExplosion(Vector3 position)
    {
        Instantiate(explosion, position, Quaternion.identity);
        Collider[] colliders = Physics.OverlapSphere(position, radius);
        foreach (Collider hit in colliders) {
            unparent unp = hit.gameObject.GetComponent<unparent>();
            if (unp != null)
            {
                unp.unparentMesh();
                Destroy(hit.GetComponent<unparent>());
                Destroy(hit.GetComponent<BoxCollider>());

            } 
            if (hit && hit.GetComponent<Rigidbody>())
                hit.GetComponent<Rigidbody>().AddExplosionForce(force, position, radius, 3.0F);
            
        }    
    }    
}
