using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {

	public float velocidadInicial = 600f;

	public Rigidbody rig;

	public bool isJuegoIniciado = false;

	Vector3 posInicial;

	public Transform barra;

	public ElementoInteractivo pantalla;

	/*
	void Awake(){
		rig = GetComponent<Rigidbody> ();
	}

	*/
	/*
	void Awake(){
		barra = GetComponentInParent<Transform>();
	}
	*/


	// Use this for initialization
	void Start () {
		posInicial = transform.position;
	}

	public void Reset(){
		transform.position = posInicial;
		transform.SetParent (barra);
		isJuegoIniciado = false;
		//rig.isKinematic = true;
		//rig.velocity = Vector3.zero;
		DetenerMovimiento();
	}

	public void DetenerMovimiento(){
		rig.isKinematic = true;
		rig.velocity = Vector3.zero;

	}

	// Update is called once per frame
	void Update () {
		if (!isJuegoIniciado && (Input.GetButtonDown ("Fire1") || pantalla.pulsado)) {
			isJuegoIniciado = true;
			transform.SetParent (null);
			rig.isKinematic = false;
			rig.AddForce (new Vector3(velocidadInicial,velocidadInicial,0));
		}
	}
}
