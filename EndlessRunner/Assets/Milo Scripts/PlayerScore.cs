using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour {

	[SerializeField]
	private Text scoreText;
	private int score;

	[SerializeField]
	private Text distanceWalked;
	private float totalDistance;

	private Vector3 lastPos;
	private Vector3 currentPos;

	private int minimunWalkPoint = 5;
	private int maximumWalkPoint = 6;
	 


	// Use this for initialization
	void Start () {
		score = 100;
		setScoreText ();

		totalDistance = 0;
		lastPos = transform.position;
		currentPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		currentPos = transform.position;
		totalDistance += Vector3.Distance(currentPos, lastPos);
		lastPos = currentPos;
		distanceWalked.text = "Total Distance: " + totalDistance.ToString();


		if (totalDistance > minimunWalkPoint && totalDistance < maximumWalkPoint) {
			score += 20;
			minimunWalkPoint *= 2;
			maximumWalkPoint = minimunWalkPoint + 1;
			setScoreText ();
		}
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
