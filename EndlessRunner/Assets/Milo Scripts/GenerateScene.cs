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





}