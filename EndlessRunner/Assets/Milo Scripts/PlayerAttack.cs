using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	[SerializeField] private Transform enemyCheck;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		RaycastHit hit;
		if (Physics.Linecast (transform.position, enemyCheck.position, out hit)) {
			Debug.Log ("enemy hit");
			if (Input.GetKeyDown (KeyCode.E)) {
				Destroy (hit.collider.gameObject);
			}
		} else {
			Debug.Log ("did not hit enemy");
		}
	}
}
