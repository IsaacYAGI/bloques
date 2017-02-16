using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour {

	public float velocidad = 20.0f;

	Vector3 posInicial;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		posInicial = transform.position;
	}

	public void Reset(){
		transform.position = posInicial;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Update");
		//-1 si es eje negativo
		//0 si no se pulsa nada
		//1 si es eje positivo
		float tecladoHorizontal = Input.GetAxisRaw("Horizontal");

		float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(posX,-8,8),transform.position.y,transform.position.z);
	}
}
