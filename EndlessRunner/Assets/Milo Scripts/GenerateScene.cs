using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateScene : MonoBehaviour {

	public GameObject[] Platforms;
	public Transform scenegenerationPoint;

	public float _distanceBetween;
	private float _platformWidth;
	private int _randomRoomIndex;

	void Start() {
		//Platforms[randomRoomIndex].GetComponent<BoxCollider2D> ().size.x;
		_platformWidth = 20.48f;
	}

	void Update() {
		int _randomRoomIndex = Random.Range(0, Platforms.Length);

		if (transform.position.x < scenegenerationPoint.position.x) {
			transform.position = new Vector2 (transform.position.x + _platformWidth + _distanceBetween, transform.position.y);
			Instantiate (Platforms[_randomRoomIndex], transform.position, transform.rotation);
		}
	
	}




}