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

		RaycastHit2D hit = Physics2D.Linecast(transform.position, enemyCheck.position , 1 << LayerMask.NameToLayer("Shroom"));
		if (hit.collider) {
			Debug.DrawLine(transform.position , enemyCheck.position , Color.green, 0.5f, false);
			if (Input.GetKeyDown (KeyCode.E)) {
				Destroy (hit.collider.gameObject);
				playerscore_ui.score += 50;
				playerscore_ui.SetScoreText ();
			}
		} else {
			Debug.DrawLine(transform.position , enemyCheck.position , Color.red, 0.5f, false);
		}
	}
}
