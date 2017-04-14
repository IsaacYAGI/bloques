using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueLvl2 : Bloque{

	public int CANTIDAD_GOLPES_PARA_DESTRUIR = 2;

	void OnCollisionEnter(){
		if (CANTIDAD_GOLPES_PARA_DESTRUIR == 2) {
			CANTIDAD_GOLPES_PARA_DESTRUIR--;
		}else{
			Instantiate (efectoParticulas,transform.position, Quaternion.identity);
			Destroy (gameObject);
			transform.SetParent (null);
			puntos.GanarPunto ();
		}

	}
}
