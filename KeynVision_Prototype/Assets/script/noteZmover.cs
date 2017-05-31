using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteZmover : MonoBehaviour {

	public float speed;
	public Transform keyFlyDirection;
	private GameObject keyboard;

	// Use this for initialization
	void Start () {
		
		keyboard = GameObject.FindGameObjectWithTag ("keyboard");
		
		Rigidbody r = GetComponent<Rigidbody> ();
		r.velocity = keyboard.transform.forward.normalized * speed * -1f;
		Vector3 targetRotation = Vector3.zero;
		targetRotation.x = keyboard.transform.rotation.eulerAngles.z;
		targetRotation.z = keyboard.transform.rotation.eulerAngles.x;
		transform.rotation = keyboard.transform.rotation;
	}

}
