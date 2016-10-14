using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceScore : MonoBehaviour {

	private Vector3 lastPos;
	private Vector3 currentPos;

	private int minimunWalkPoint = 20;
	private int maximumWalkPoint = 21;

	private float totalDistance;

	// Use this for initialization
	void Start () {
		lastPos = transform.position;
		currentPos = transform.position;
		totalDistance = 0;


	}
	
	// Update is called once per frame
	void Update () {
		GameObject Player = GameObject.Find ("Player");
		PlayerScore_UI playerscore_ui = Player.GetComponent<PlayerScore_UI> ();
	

		currentPos = transform.position;
		currentPos.y = 0;
		totalDistance += Vector3.Distance(currentPos, lastPos);
		lastPos = currentPos;


		if (totalDistance > minimunWalkPoint && totalDistance < maximumWalkPoint) {
			playerscore_ui.score += 100;
			minimunWalkPoint += 20;
			maximumWalkPoint = minimunWalkPoint + 1;
			playerscore_ui.SetScoreText ();

		}
	}
}

