using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class simpleZmover : MonoBehaviour {
	public float speed;
	public Transform keyFlyDirection;

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, keyFlyDirection.position, speed * Time.deltaTime);
	}
}