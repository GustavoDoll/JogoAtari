using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoAtirar : MonoBehaviour {
	public float velocidadeTiro;
	public Transform projetil;

	// Use this for initialization
	IEnumerator Start () {

		float t =Random.Range(2.0f , 5.0f);
		yield return new WaitForSeconds (t);

		Instantiate (projetil,transform.position,transform.rotation);
	
		StartCoroutine (Start ());
	}

}
