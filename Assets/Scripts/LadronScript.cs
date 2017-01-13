using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronScript : MonoBehaviour {
	
	GameObject pringao;
	CarteraScript carteraPringao;

	// Use this for initialization
	void Start () {
		pringao = GameObject.Find ("Ricarpito");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			carteraPringao = pringao.GetComponent<CarteraScript> ();
			carteraPringao.donacion (-5);
		}
	}
}
