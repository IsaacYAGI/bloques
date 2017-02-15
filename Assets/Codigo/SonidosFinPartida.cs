using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosFinPartida : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip completado,
					 gameOver;

	public void GameOver(){
		ReproducirSonido (gameOver);
	}

	public void NivelCompletado(){
		ReproducirSonido (completado);
	}

	void ReproducirSonido(AudioClip sonido){
		//Se asigna musica nueva
		audioSource.clip = sonido;
		//Solo se requiere que se reproduzca una sola vez, por lo que se quita el loop
		audioSource.loop = false;
		//Despues de setear los audioSource se reproduce el nuevo valor
		audioSource.Play ();
	}
}
