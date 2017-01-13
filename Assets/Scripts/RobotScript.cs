using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour {


	Rigidbody2D robotRg;
	SpriteRenderer spriteRobot;
	public float velocidad = 5;
	// Use this for initialization
	void Start () {
		robotRg = GetComponent<Rigidbody2D> ();
		spriteRobot = GetComponent <SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			robotRg.velocity = new Vector2 (velocidad, 0);
			spriteRobot.flipX = false;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			robotRg.velocity = new Vector2 (-velocidad, 0);
			spriteRobot.flipX = true;
		}
	}
}
