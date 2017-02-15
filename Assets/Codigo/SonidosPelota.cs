using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour {

	//Referencias a los audiosource

	public AudioSource rebote;
	public AudioSource punto;
	//Se agrega el Audiosource para reproducir el sonido de error
	public AudioSource error;

	void OnCollisionEnter(Collision otro){
		if (otro.gameObject.CompareTag ("Bloque")) {
			punto.Play ();
		} else {
			rebote.Play ();
		}
	}

	//Se agrega el metodo OnTriggerEnter debido a que el suelo posee el isTrigger activado
	void OnTriggerEnter(Collider otro){
		if (Vidas.vidas != 0) {//Si las vidas son diferentes de 0, es decir, se puede continuar jugando, se reproduce el sonid de error
			if (otro.gameObject.CompareTag ("Suelo")) {
				error.Play ();
			}
		}
		//En caso de que no se pueda continuar jugando el gestor del juego hara sonar el sonido de Game Over
	}
}
