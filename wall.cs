using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wall : MonoBehaviour {
	static private int pointsLeft;
	static private int pointsRight;

	public Text left;
	public Text right;
	// Use this for initialization
	void Start () {
		left.text = "";
		right.text = "";

		left.text = pointsLeft.ToString();
		right.text = pointsRight.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			
		}

	}

	void OnTriggerEnter2D() {
		if(this.tag == "left" ) {
			pointsRight++;
			Debug.Log("Right" +pointsRight);
			SceneManager.LoadScene(SceneManager.GetActiveScene ().name);

		} else {
			pointsLeft++;
			Debug.Log("left" +pointsLeft);
			SceneManager.LoadScene(SceneManager.GetActiveScene ().name);
		}

	}
}
