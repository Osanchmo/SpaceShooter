using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
	public GameObject ship;

	public float interval = 2;
	void Start() {
		InvokeRepeating("SpawnNext",interval, interval);
	}

	void SpawnNext (){
		Instantiate(ship, transform.position, Quaternion.identity);
	}
}
