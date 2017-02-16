using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

	public static int vidas = 3;

	public Text textoVidas;
	public Pelota pelota;
	public Barra barra;

	public GameObject gameOver;
	public SiguienteNivel siguienteNivel;

	public SonidosFinPartida sonidosFinPartida;

	// Use this for initialization
	void Start () {
		//textoVidas.text = "Vidas: " + Vidas.vidas;
		ActualizarMarcadorVidas();
	}
	
	public void PerderVida(){

		if (Vidas.vidas <= 0)
			return;

		Vidas.vidas--;
		ActualizarMarcadorVidas ();

		if (Vidas.vidas <= 0) {
			sonidosFinPartida.GameOver ();
			//Mostrar Gameover
			gameOver.SetActive(true);
			//Se detiene la pelota
			pelota.DetenerMovimiento ();
			//Se desactiva el script del objeto barra para evitar su movimiento
			barra.enabled = false;
			//Al perder todas las vidas, se debe especificar la pantalla a redirigir
			siguienteNivel.nivelACargar = "Portada";
			//Y luego activar la pantalla
			siguienteNivel.ActivarCarga ();
		}else{
			barra.Reset ();
			pelota.Reset ();
		}


	}

	void ActualizarMarcadorVidas(){
		textoVidas.text = "Vidas: " + Vidas.vidas;
	}
}
