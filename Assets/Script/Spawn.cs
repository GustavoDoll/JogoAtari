using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject[] inimigo;
	// Use this for initialization
	IEnumerator Start () {

		float t = (2.0f);
		yield return new WaitForSeconds (t);
		int i = Random.Range (0, inimigo.Length);

		Vector3 pos = new Vector3 (-8.0f, -4.49f, -0.5f);
		Instantiate (inimigo[i],pos ,transform.rotation);
		StartCoroutine (Start ());
	}
}
	
	// Update is called once per frame

