using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

	[SerializeField]
	private Text lifeText;
	private int Lifes;

	// Use this for initialization
	void Start () {
		Lifes = 3;
		lifeText.text = "Life's: " + Lifes.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
