using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paddle : MonoBehaviour {
	public float speed = 30;
	public string axis = "Vertical";
	public int pointsLeft = 0;
	public int pointsRight = 0;
	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxisRaw (axis);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,v) * speed;
	}
}
