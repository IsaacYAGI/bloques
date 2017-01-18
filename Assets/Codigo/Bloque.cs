using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

	public GameObject efectoParticulas;

	//is Trigger desactivado, los objetos son solidos
	void OnCollisionEnter(){
		Instantiate (efectoParticulas,transform.position, Quaternion.identity);
		Destroy (gameObject);
	}

	//Is trigger activado, los objetos se atraviesan
	/*void OnTriggerEnter(){
		
		
	}*/
}
