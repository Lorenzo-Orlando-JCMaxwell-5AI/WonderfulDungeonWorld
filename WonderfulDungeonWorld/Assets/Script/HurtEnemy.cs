﻿using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTreiggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
	}
}