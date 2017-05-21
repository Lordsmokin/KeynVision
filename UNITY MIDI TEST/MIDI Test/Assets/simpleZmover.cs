using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class simpleZmover : MonoBehaviour {

	public GameObject noteClone;
	public float speed;
	public float destroyMissedNote;
	public float hitZone;
	public Transform keyFlyDirection;
	public int noteNumber;
	private GameObject keyboard;


	void Start () {
		
		keyboard = GameObject.FindGameObjectWithTag ("keyboard");

		Rigidbody r = GetComponent<Rigidbody> ();
		r.velocity = keyboard.transform.forward.normalized * speed * -1f;
		Vector3 targetRotation = Vector3.zero;
		targetRotation.x = keyboard.transform.rotation.eulerAngles.z;
		targetRotation.z = keyboard.transform.rotation.eulerAngles.x;
		transform.rotation = keyboard.transform.rotation;

	}

	void Update () {

		if (noteClone.transform.position.z <= hitZone && MidiMaster.GetKeyDown (noteNumber)) {
			Destroy (noteClone.gameObject);
		} else if (noteClone.transform.position.z <= hitZone && MidiMaster.GetKeyDown (noteNumber)) {
			Destroy (noteClone.gameObject);
//			(noteClone.transform.position.z <= destroyMissedNote) {
//			Destroy (gameObject);
		}


	}

}