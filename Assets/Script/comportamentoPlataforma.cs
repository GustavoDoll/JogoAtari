using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoPlataforma : MonoBehaviour {



	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.tag == "Bala" || col.gameObject.tag=="BalaInimigo"){
			col.gameObject.SetActive (false);
			Destroy (gameObject);

		}
	}
}
