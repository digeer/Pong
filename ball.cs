﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	public float speed = 15;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	void OnCollisionEnter2D(Collision2D col) {
		if ( col.gameObject.name == "PaddleLeft") {
			// Calculate hit Factor
			float y = hitFactor(transform.position,
				col.transform.position,
				col.collider.bounds.size.y);

			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(1, y).normalized;

			// Set Velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}

		// Hit the right Racket?
		if (col.gameObject.name == "PaddleRight") {
			// Calculate hit Factor
			float y = hitFactor(transform.position,
				col.transform.position,
				col.collider.bounds.size.y);

			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(-1, y).normalized;

			// Set Velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
	} 

	float hitFactor (Vector2 ballPos, Vector2 racketPos, float racketHeight) {
		return (ballPos.y - racketPos.y) / racketHeight;
	}
}
