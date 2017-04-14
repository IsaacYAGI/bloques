using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueLvl2 : Bloque{

	public int CANTIDAD_GOLPES_PARA_DESTRUIR = 2;
	private int golpesRecibidos = 1;

	void OnCollisionEnter(){
		if (golpesRecibidos != CANTIDAD_GOLPES_PARA_DESTRUIR) {
			golpesRecibidos++;
		}else{
			Instantiate (efectoParticulas,transform.position, Quaternion.identity);
			Destroy (gameObject);
			transform.SetParent (null);
			puntos.GanarPunto ();
		}

	}
}
