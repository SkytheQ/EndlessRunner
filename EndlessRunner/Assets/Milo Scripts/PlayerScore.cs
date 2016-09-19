using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour {

	public Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {
		score = 100;
		setScoreText ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Enemy")) {
			if (score == 0) {
				score = 0;
			} else {
				score -= 20;
			}
		
			setScoreText ();
		}
	}

	void setScoreText() {
		scoreText.text = "Score: " + score.ToString();
	}
}
