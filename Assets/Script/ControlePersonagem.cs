using UnityEngine;
using System.Collections;

public class ControlePersonagem : MonoBehaviour {

	public float velocidade = 5f;
	public float forcaPulo = 200f;
	private bool facingRight = true;
	private float movX;
	private Rigidbody2D rb;
	public AudioSource som;
	public Transform chaoVerificador;
	bool estaNoChao;
	public float limiteEsquerdo,limiteDireito;


	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();

	}
	void Awake(){
		transform.tag="Player";
	}
	void Move(){
		movX = Input.GetAxisRaw ("Horizontal");
		if (movX > 0 && !facingRight) {
			Flip();
		}
		else if (movX<0 && facingRight) {
			Flip ();
		}
		rb.velocity = new Vector2 (movX * velocidade , rb.velocity.y);

		if (Input.GetKeyDown("up") && estaNoChao==true) {
			rb.AddForce (new Vector2(rb.velocity.x,forcaPulo));
			Som();
		}

	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 scale = GetComponent<Transform> ().localScale;
		scale.x *= -1;
		GetComponent<Transform>().localScale = scale;

	}
	// Update is called once per frame
	void Update () {
		Move ();
		estaNoChao = Physics2D.Linecast (transform.position,chaoVerificador.transform.position, 1 << LayerMask.NameToLayer("chao"));
		Wrap (limiteEsquerdo,limiteDireito);
		
	}
	void Wrap(float limiteEsquerdo, float LimiteDireito){
		if (transform.position.x < limiteEsquerdo) {
			transform.position = new Vector2 (LimiteDireito, 3.78f);
		} else if (transform.position.x > LimiteDireito) {
			transform.position = new Vector2 (limiteEsquerdo, 3.78f);
		}

	}
		



	void Som(){
		
		som.Play ();
	}
}
		