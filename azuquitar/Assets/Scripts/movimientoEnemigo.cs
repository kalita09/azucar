using UnityEngine;
using System.Collections;

public class movimientoEnemigo : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate () {
		float azar = Random.value*10;
		if (azar > 5) {
			transform.Translate (speed * Time.deltaTime, 0, 0);
		} else {
			transform.Translate (-speed * Time.deltaTime, 0, 0);
		}


	
	}


}
