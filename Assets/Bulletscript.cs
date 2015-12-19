using UnityEngine;
using System.Collections;

public class Bulletscript : MonoBehaviour {

    // Use this for initialization
    public float speed = 100;
    public float amount = 10;
    public Rigidbody projectile;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiateProjectile =  Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiateProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            
            Debug.Log("Pew");
        }
            
      
	
	}
}
