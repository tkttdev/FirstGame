using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float acceleration = 1000;

	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		gameObject.GetComponent<Rigidbody> ().AddForce (new Vector2 (acceleration * inputX, 0), ForceMode.Impulse);
	}
}
