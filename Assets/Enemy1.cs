using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour {

    public Rigidbody enemy1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Rigidbody instantiateProjectile = Instantiate(enemy1, transform.position, transform.rotation) as Rigidbody;
        instantiateProjectile.transform.position += Random.insideUnitSphere * 1000;
    }
}
