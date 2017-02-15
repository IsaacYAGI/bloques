using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

	public GameObject efectoParticulas;
	public Puntos puntos;

	//is Trigger desactivado, los objetos son solidos
	void OnCollisionEnter(){
		Instantiate (efectoParticulas,transform.position, Quaternion.identity);
		Destroy (gameObject);
		transform.SetParent (null);
		puntos.GanarPunto ();
	}

	//Is trigger activado, los objetos se atraviesan
	/*void OnTriggerEnter(){
		
		
	}*/
}
