﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	public Vector2 speed = new Vector2(50,50);
	private Vector2 movement;

	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		movement = new Vector2 (
			speed.x * inputX,
			speed.y * inputY);

		bool shoot = Input.GetButtonDown ("Fire1");
		shoot |= Input.GetButtonDown ("Fire2");

		if (shoot) {
			WeaponScript weapon = GetComponent<WeaponScript>();
			if(weapon != null) {
				weapon.Attack(false);
			}
		}
	
	}

	void FixedUpdate() {
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}
