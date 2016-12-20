using UnityEngine;
using System.Collections;

public class PlayerBlue : MonoBehaviour {
	
	public float velocidad = 5f;
	private Rigidbody2D rb;



	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D) )
		{
			rb.velocity = new Vector2 (velocidad,rb.velocity.y);


		}

		if (Input.GetKey (KeyCode.A)) 
		{
			rb.velocity = new Vector2 (-velocidad,rb.velocity.y);


		}

		if (Input.GetKey (KeyCode.W)) 
		{
			rb.velocity = new Vector2 (velocidad,rb.velocity.x); //va inclinado y nose porque


		}

		if (Input.GetKey (KeyCode.S)) 
		{
			rb.velocity = new Vector2 (-velocidad, rb.velocity.x); //va inclinado y nose porque


		}



	}


}
