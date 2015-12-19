using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
    public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision hit)
    {
      RaycastHit[] hits =  Physics.SphereCastAll(transform.position, 50, Vector3.zero);
        foreach(RaycastHit h in hits)
            {
            h.collider.gameObject.GetComponent<Rigidbody>().AddExplosionForce(10, transform.position, 50);
        }
        GameObject Explosion = Instantiate(explosion, transform.position, new Quaternion()) as GameObject;
        Destroy(Explosion, 0.25f);
        Destroy(gameObject);
    }
}
