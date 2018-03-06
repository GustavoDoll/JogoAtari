using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalInimigocpto : MonoBehaviour {
	public float velocidade;
	 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * velocidade * Time.deltaTime);
		Destroy (gameObject, 3f);
}


	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Player") {
			Application.LoadLevel ("TelaInicial");

		}
	}
}