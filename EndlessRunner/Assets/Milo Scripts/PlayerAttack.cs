using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	[SerializeField] private Transform EnemyCheck;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		RaycastHit hit;
		if (Physics.Linecast (transform.position, /*-Vector2.up*/ EnemyCheck.position, out hit)) {
			print("touch hit: " + hit.collider.gameObject.name);
			if (Input.GetKeyDown (KeyCode.E)) {
				Destroy (hit.collider.gameObject);
			}
		} else {
			print("Did not touch Enemy");
		}
	}
}
