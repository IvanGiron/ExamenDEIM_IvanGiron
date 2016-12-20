using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	public float velocidad = 5f;
	private Rigidbody2D rb;



	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey ("right")) 
		{
			rb.velocity = new Vector2 (velocidad,rb.velocity.y);
		

		}

		 if (Input.GetKey ("left")) 
		{
			rb.velocity = new Vector2 (-velocidad,rb.velocity.y);


		}

		if (Input.GetKey ("up")) 
		{
			rb.velocity = new Vector2 (velocidad,rb.velocity.x); //va inclinado y nose porque


		}

		 if (Input.GetKey ("down")) 
		{
			rb.velocity = new Vector2 (-velocidad, rb.velocity.x); //va inclinado y nose porque


		}



	}


}
