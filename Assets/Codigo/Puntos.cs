using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {
	public static int puntos = 0;
	public Text textoPuntos;

	void ActualizarMarcadorPuntos(){
		textoPuntos.text = "Puntos: " + Puntos.puntos;
	}

	void Start(){
		ActualizarMarcadorPuntos ();
	}

	public void GanarPunto(){
		Puntos.puntos++;
		ActualizarMarcadorPuntos ();
	}

}
