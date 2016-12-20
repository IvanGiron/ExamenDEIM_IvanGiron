using UnityEngine;
using System.Collections;

public class Pelota : MonoBehaviour {

	private Rigidbody2D rigi;
	GameObject txtPelota;
	PelotaControl ctrl_pelota;
	public int suma;
	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody2D>();
		txtPelota = GameObject.Find ("verdeMarcador"); //busca los objetos en la escena y el del nombre lo mete
		ctrl_pelota = txtPelota.GetComponent<PelotaControl>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Porteria") {
			Destroy (gameObject);
			ctrl_pelota.sumaMonedas (suma);
			// Se destruye a 1 segundo de tocarla

		}
	}

}
