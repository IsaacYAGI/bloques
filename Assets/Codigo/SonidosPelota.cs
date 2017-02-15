using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour {

	//Referencias a los audiosource

	public AudioSource rebote;
	public AudioSource punto;
	public AudioSource error;

	void OnCollisionEnter(Collision otro){
		if (otro.gameObject.CompareTag ("Bloque")) {
			punto.Play ();
		} else {
			rebote.Play ();
		}
	}

	void OnTriggerEnter(Collider otro){
		if (Vidas.vidas != 0) {
			if (otro.gameObject.CompareTag ("Suelo")) {
				error.Play ();
			}
		}
	}
}
