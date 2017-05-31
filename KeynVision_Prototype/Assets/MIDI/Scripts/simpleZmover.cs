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
	private bool amIInTheHitzone = false;
	private bool shallBeDestroyed = false;

	void Start () {
		/*
		keyboard = GameObject.FindGameObjectWithTag ("keyboard");

		Rigidbody r = GetComponent<Rigidbody> ();
		r.velocity = keyboard.transform.forward.normalized * speed * -1f;
		Vector3 targetRotation = Vector3.zero;
		targetRotation.x = keyboard.transform.rotation.eulerAngles.z;
		targetRotation.z = keyboard.transform.rotation.eulerAngles.x;
		transform.rotation = keyboard.transform.rotation;

		Debug.Log ("Note created" + noteNumber);
		*/
	}

	void Update () {

			transform.position = Vector3.MoveTowards (transform.position, keyFlyDirection.position, speed * Time.deltaTime);

		//change this to do the destroying of missed notes:
		if (gameObject.transform.position.z > destroyMissedNote) {
			Debug.Log ("Destroying note " + noteNumber);
			Destroy (noteClone.gameObject);
		}
	}

	void OnTriggerEnter(Collider hitZone) {
		if (hitZone.gameObject.name == "HitZone") {
			Debug.Log ("I am in the hitzone " + noteNumber);
			amIInTheHitzone = true;
		}
	}
	void OnTriggerExit(Collider hitZone) {
		if (hitZone.gameObject.name == "HitZone") {
			Debug.Log ("I am out of the hitzone" + noteNumber);
			amIInTheHitzone = false;
		}
	}

	void NoteOn(MidiChannel channel, int note, float velocity)
	{
		if (amIInTheHitzone && note == noteNumber) {
			Debug.Log ("Will be destroying note " + noteNumber);
			shallBeDestroyed = true;
		}
	}

	void NoteOff(MidiChannel channel, int note)
	{
		if (shallBeDestroyed && note == noteNumber) {
			Debug.Log ("Now destroying note " + noteNumber);
			Destroy (noteClone.gameObject);
		}
	}

	void OnEnable()
	{
		MidiMaster.noteOnDelegate += NoteOn;
		MidiMaster.noteOffDelegate += NoteOff;
	}

	void OnDisable()
	{
		MidiMaster.noteOnDelegate -= NoteOn;
		MidiMaster.noteOffDelegate -= NoteOff;
	}
}