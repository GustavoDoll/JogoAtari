using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {
	public float velocidade;

	public float LimiteEsquerdo;
	public float LimiteDireito;
	// Use this for initialization
	IEnumerator Start () {
		float t = (10.0f);
		yield return new WaitForSeconds (t);
		Destroy (gameObject);
	}


	void Update(){
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);

		Wrap (LimiteDireito,LimiteEsquerdo);
	}
	void Wrap(float limiteEsquerdo, float LimiteDireito){
		//transform.Translate (Vector2.right * velocidade * Time.deltaTime);
		if (transform.position.x > limiteEsquerdo) {
			transform.position = new Vector2 (LimiteDireito, -2.26f);


		} else if (transform.position.x < LimiteDireito) {
			transform.position = new Vector2 (limiteEsquerdo, -2.26f);

		}

	}

	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.tag == "Bala"){
			col.gameObject.SetActive (false);
			Destroy (gameObject);
			Score.pontos++;
		}
	}


}
