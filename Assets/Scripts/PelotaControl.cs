using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PelotaControl : MonoBehaviour {


	private int monedas = 0;
	Text Texto;

	void Start(){
		Texto = GetComponent<Text> ();
		resetear ();
		sumaMonedas (0);
	}

	public void sumaMonedas(int cantidad){
		monedas = monedas + cantidad; // o tambien: monedas += cantidad;
		if (monedas < 0){
			monedas = 0;
		} 

		Texto.text = monedas.ToString ();
	}

	public void resetear(){
		monedas = 0;
		Texto.text = monedas.ToString ();
	}

	public void siguienteNivel (){
		if (monedas == 5){
			Application.LoadLevel("Nave");
		}

	}
}
