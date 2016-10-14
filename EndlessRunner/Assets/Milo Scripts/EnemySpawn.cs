using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject Enemy;
	public float spawnTime = 1.5f;
	public GameObject[] enemies;

	float x = -53.41f;
	float y = -1.7f;
	float z = -0.2f;
	Vector3 SpawnPosition;

	// Use this for initialization
	void Start () {
		SpawnPosition = new Vector3 (x,y,z);
		//transform.position = pos;
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn() {
		GameObject Player = GameObject.Find ("Player");
		PlayerLife playerlifes = Player.GetComponent<PlayerLife> ();
		if (playerlifes.Lifes <= 0f) {
			return;
		} else {
			Instantiate (enemies[0], SpawnPosition, transform.rotation);
			SpawnPosition.x += 15;
		}
	}
}
