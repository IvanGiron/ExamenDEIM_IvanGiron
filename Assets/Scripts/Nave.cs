using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {

	private Rigidbody2D rb;
	public float fuerza = 10f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Space)) {

			rb.AddForce (transform.up*fuerza);

		}

	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Meteoritos") {

			Destroy (gameObject); // sE DESTRUYE A LOS 3 SEGUNDOS
		}
	}
}
