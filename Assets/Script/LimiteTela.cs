using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteTela : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D c){

		if (c.GetComponent<Collider2D>().tag == "Player") {


			Application.LoadLevel ("TelaInicial");

		}
	}
}
