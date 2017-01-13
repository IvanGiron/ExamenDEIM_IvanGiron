using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarteraScript : MonoBehaviour {

	int monedas = 100;
	public Text textoMonedas;
	void Update(){
		textoMonedas.text = monedas.ToString ();
	}

	public void donacion (int dinero) {
		if(dinero>0){
			monedas += dinero;
		}

	}
}
