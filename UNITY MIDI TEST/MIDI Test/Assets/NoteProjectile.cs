﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteProjectile : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		Rigidbody r = GetComponent<Rigidbody> ();
		r.velocity = Vector3.back * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
