using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteZmover : MonoBehaviour {

	public float speed;
	public bool greaterThan = true;
	public float zPosition;

	// Use this for initialization
	void Start () {
		Rigidbody r = GetComponent<Rigidbody> ();
		r.velocity = Vector3.back * speed;
	}
	
	// Update is called once per frame
	void Update () {
		if ((greaterThan && transform.position.z < zPosition) ||
			(!greaterThan && transform.position.z > zPosition))
			Destroy(gameObject);
	}
}
