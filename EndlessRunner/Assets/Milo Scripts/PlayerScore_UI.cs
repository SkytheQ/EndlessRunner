using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScore_UI : MonoBehaviour {

	[SerializeField]
	private Text scoreText;

	public int score;

	public Text distanceWalked;

	// Use this for initialization
	void Start () {
		score = 0;
		SetScoreText ();

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Enemy")) {
			if (score == 0) {
				score = 0;
			} else {
				score -= 50;
			}
		
			SetScoreText ();
		}
	}

	public void SetScoreText() {
		scoreText.text = "Score: " + score.ToString();
	}
}
