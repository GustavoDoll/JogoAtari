using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour {
	public Transform bala;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Instantiate (bala,transform.position, Quaternion.identity );
		}

	}
}
