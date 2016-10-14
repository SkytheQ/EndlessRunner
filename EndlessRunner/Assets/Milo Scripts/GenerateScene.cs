using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateScene : MonoBehaviour {

	public GameObject Platform;
	public Transform generationPoint;

	public float distanceBetween;
	private float platformWidth;


	void Start() {
		platformWidth = Platform.GetComponent<BoxCollider2D> ().size.x;
	}

	void Update() {
		
		if (transform.position.x < generationPoint.position.x) {
			transform.position = new Vector2 (transform.position.x + platformWidth + distanceBetween, transform.position.y);
			Instantiate (Platform, transform.position, transform.rotation);
		}
	
	}




}