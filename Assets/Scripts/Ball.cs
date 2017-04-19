using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	void Start () {
		gameObject.GetComponent<Rigidbody> ().AddForce (new Vector2 (5, 5), ForceMode.VelocityChange);
	}

	void OnCollisionEnter(Collision other){
		if (other.transform.tag == "DeadZone") {
			Destroy (gameObject);
			Debug.Log ("GameOver");
		}
	}
}
