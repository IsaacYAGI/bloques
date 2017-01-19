using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

	public static int vidas = 3;

	public Text textoVidas;
	public Pelota pelota;
	public Barra barra;

	// Use this for initialization
	void Start () {
		//textoVidas.text = "Vidas: " + Vidas.vidas;
		ActualizarMarcadorVidas();
	}
	
	public void PerderVida(){
		Vidas.vidas--;
		ActualizarMarcadorVidas ();
		barra.Reset ();
		pelota.Reset ();
	}

	void ActualizarMarcadorVidas(){
		textoVidas.text = "Vidas: " + Vidas.vidas;
	}
}
