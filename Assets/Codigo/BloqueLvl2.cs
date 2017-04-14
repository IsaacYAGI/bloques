using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueLvl2 : Bloque{

	public int CANTIDAD_GOLPES_PARA_DESTRUIR = 2;
	private int golpesRecibidos = 1;

	void OnCollisionEnter(){
		if (golpesRecibidos != CANTIDAD_GOLPES_PARA_DESTRUIR) {
			golpesRecibidos++;

			//Si en el proximo golpe se va a destruir el bloque
			/*
			if (isProximoGolpeDestruye()) {
				//Se cambia el color del bloque

			}
			*/
		}else{
			Instantiate (efectoParticulas,transform.position, Quaternion.identity);
			Destroy (gameObject);
			transform.SetParent (null);
			puntos.GanarPunto ();
		}

	}
	/*
	bool isProximoGolpeDestruye(){
		return golpesRecibidos == CANTIDAD_GOLPES_PARA_DESTRUIR;
	}
	*/
}
