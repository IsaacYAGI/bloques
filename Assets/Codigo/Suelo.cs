﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

	public Vidas vidas;

	void OnTriggerEnter(){
		vidas.PerderVida ();
		Debug.Log ("Usuario ha perdido una vida");

	}
}
