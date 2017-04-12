using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour {

	public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			//spawn bullet
			GameObject g = (GameObject) Instantiate(bullet, transform.position,Quaternion.identity);
//Ignore bullet -> player collisions
			Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),
				transform.parent.GetComponent<Collider2D>());
		}
	}
}
