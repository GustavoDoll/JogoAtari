using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoBala : MonoBehaviour {
	public float velocidade;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * velocidade * Time.deltaTime);
		//Destroy (gameObject, 2f);

	}




}
