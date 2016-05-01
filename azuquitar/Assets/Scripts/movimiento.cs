using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	float velocidad = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float inputX = Input.GetAxis ("Horizontal");
		Debug.Log ("He pulsado" + inputX);
		float mivelocidady = gameObject.GetComponent<Rigidbody2D> ().velocity.y; 
		//Delta time para hacerlo independiente del frame rate, solo del tiempo si es que lo necesito poner en update, en fixedupdate es independiente 
		// del frame rate
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector3 (inputX*velocidad, mivelocidady, 0);

	
	}
}
