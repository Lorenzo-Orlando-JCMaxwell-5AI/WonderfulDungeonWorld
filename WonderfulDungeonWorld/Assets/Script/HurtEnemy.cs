﻿using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

	public int damageToGive;
	public GameObject damageBurst;
	public Transform hitPoint;

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
			//Destroy(other.gameObject);
			other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
			Instantiate (damageBurst, hitPoint.position, hitPoint.rotation);
		}
	}
}