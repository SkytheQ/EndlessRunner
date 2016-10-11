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
	void OnCollisionEnter2D(Collision2D coll) {
		GameObject Player = GameObject.Find ("Player");
		PlayerLife playerlifes = Player.GetComponent<PlayerLife> ();
		if (coll.gameObject.CompareTag("Enemy")) {
			if (score == 0) {
				score = 0;
			} else {
				score -= 50;
				playerlifes.Lifes -= 1;
				Destroy (coll.gameObject);
				Debug.Log (playerlifes.Lifes);
			}
			playerlifes.SetLifeText ();
			SetScoreText ();
		}

	}


	public void SetScoreText() {
		scoreText.text = "Score: " + score.ToString();
	}
}
