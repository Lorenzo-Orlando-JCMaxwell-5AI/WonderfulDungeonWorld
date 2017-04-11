﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

	public string levelToLoad;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.name == "$Player_1")
		{
			SceneManager.LoadScene(levelToLoad);
		}
	}
}