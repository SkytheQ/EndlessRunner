using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour {

	public Text lifeText;
	public int Lifes;

	// Use this for initialization
	void Start () {
		Lifes = 3;
		SetLifeText ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Lifes <= 0) {
			Lifes = 0;
			SceneManager.LoadScene(3);
		}
	}

	public void SetLifeText() {
		lifeText.text = "Life's: " + Lifes.ToString();
	}
}
