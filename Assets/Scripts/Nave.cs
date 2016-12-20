using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Meteoritos") {

			Destroy (gameObject); // sE DESTRUYE A LOS 3 SEGUNDOS
		}
	}
}
