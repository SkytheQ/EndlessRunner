﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void loadLevel(string _loadLevel)
	{
		SceneManager.LoadScene(0);
	}
}
