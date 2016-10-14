using UnityEngine;
using System.Collections;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject sceneDestructionPoint;	

	// Use this for initialization
	void Start () {
		sceneDestructionPoint = GameObject.Find ("SceneDestructionPoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < sceneDestructionPoint.transform.position.x){
			
		}
	}
}
