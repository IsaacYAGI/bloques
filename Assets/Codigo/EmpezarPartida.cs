using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour {

	public ElementoInteractivo pantalla;

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") || pantalla.pulsado){	
			Vidas.vidas = 3;
			Puntos.puntos = 0;
			SceneManager.LoadScene ("Nivel01");
		}
	}
}
