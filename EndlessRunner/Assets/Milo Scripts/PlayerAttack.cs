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
		GameObject Player = GameObject.Find ("Player");
		PlayerScore_UI playerscore_ui = Player.GetComponent<PlayerScore_UI> ();

		RaycastHit hit;
		if (Physics.Linecast (transform.position, enemyCheck.position, out hit)) {
			Debug.Log ("enemy hit");
			if (Input.GetKeyDown (KeyCode.E)) {
				Destroy (hit.collider.gameObject);
				playerscore_ui.score += 50;
				playerscore_ui.SetScoreText ();
			}
		} else {
			Debug.Log ("did not hit enemy");
		}
	}
}
