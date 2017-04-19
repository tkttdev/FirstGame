using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	void Start () {
		//初めてのUnity
		Debug.Log ("Hello, World!!");

		//自己紹介
		int age = 21;
		float height = 169.7f;
		string name = "Tatsuhito Takamiya";
		bool isAdult = age > 19;

		Debug.Log ("私の名前は" + name + "で，年齢は" + age + "，身長は" + height + "です");
		age += 1;
		Debug.Log ("来年は" + age + "歳になります");

		//構文勉強
		if (age > 19) {
			Debug.Log ("成人なのでお酒が飲めます");
		} else {
			Debug.Log ("成人ではないのでお酒が飲めません");
		}

		for (int i = 0; i < 3; i++) {
			Debug.Log ("for文の" + i + "回目です");
		}

		//Unityに関して
		//transform.position += new Vector3 (0.1f, 0, 0);
	}

	//1frameに1回呼ばれるよ
	//大体1/60
	void Update () {
		transform.position += new Vector3 (0.1f, 0, 0);
	}
}
