using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour {
	private Animator animator;
	public AudioSource som;
	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator> ();
	
		animator.SetBool ("parado", true);
		animator.SetBool ("atirar",false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {


			animator.SetBool ("atirar",true);
			tocarSom ();
		}
		else if (Input.GetButtonDown("Horizontal")){
			animator.SetBool ("atirar",false);
		}
		else if (Input.GetKeyDown("up")) {
			animator.SetBool ("atirar",false);
		}
	}

	void tocarSom(){
		som.Play ();

	}


}
