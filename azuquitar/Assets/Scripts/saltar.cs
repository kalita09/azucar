using UnityEngine;
using System.Collections;

public class saltar : MonoBehaviour {

	public float fuerzasalto = 30f;
	int cuentasalto=5;
	//un objeto transform
	public Transform pie;
	//almacena capa
	public LayerMask suelo;
	public bool estaenelsuelo=false;
	public float radiopie=0.4f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate () {
		// si el punto "pie" que me dan con radio radiopie, toca la capa suelo que me dan
		estaenelsuelo=Physics2D.OverlapCircle(pie.position,radiopie,suelo);
		//si pulso la tecla
		if(Input.GetKey("up")&& (estaenelsuelo == true)){
			//
			gameObject.GetComponent<Rigidbody2D> ().velocity= new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x,0);
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, fuerzasalto*cuentasalto));

		}
		if(Input.GetKey("up")&& (estaenelsuelo == false)&&cuentasalto>0 && (gameObject.GetComponent<Rigidbody2D>().velocity.y>0)){
			//

			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, fuerzasalto*cuentasalto));
			cuentasalto = cuentasalto - 1;

		}
		if (!Input.GetKey ("up") && estaenelsuelo) {
			cuentasalto = 5;
		}

	}
}
