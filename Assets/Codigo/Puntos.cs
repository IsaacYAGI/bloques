using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {
	public static int puntos = 0;
	public Text textoPuntos;

	public GameObject nivelCompletado;
	public GameObject juegoCompletado;

	public SiguienteNivel siguienteNivel;

	public Pelota pelota;
	public Barra barra;

	public Transform contenedorBloques;

	void ActualizarMarcadorPuntos(){
		textoPuntos.text = "Puntos: " + Puntos.puntos;
	}

	void Start(){
		ActualizarMarcadorPuntos ();
	}

	public void GanarPunto(){
		Puntos.puntos++;
		ActualizarMarcadorPuntos ();

		if (contenedorBloques.childCount <= 0) {//Si no tiene hijos... se acabo el nivel
			//Se detiene la pelota
			pelota.DetenerMovimiento ();
			//Se desactiva el script del objeto barra para evitar su movimiento
			barra.enabled = false;

			if (siguienteNivel.EsUltimoNivel ()) {
				juegoCompletado.SetActive (true);
			}else{
				nivelCompletado.SetActive (true);
			}

			siguienteNivel.ActivarCarga ();
		}
	}

}
