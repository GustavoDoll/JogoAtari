using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarJogo : MonoBehaviour {
	public bool inGame;

	// Use this for initialization
	void Start () {
		if (inGame) {
			Score.pontos = 0;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		EntrarJogo ();

}
	void EntrarJogo(){
		if (Input.GetButtonDown("Submit") && inGame==false) {
			Application.LoadLevel ("jogo");
		}
	}
	}