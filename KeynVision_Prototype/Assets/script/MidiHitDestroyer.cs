using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class MidiHitDestroyer : MonoBehaviour {
	public int noteNumber;
	public bool destroyOnKeyDown = false;
	private bool amIInTheHitzone = false;

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
			if (destroyOnKeyDown) {
				DestroyNote ();
			}
		}
	}

	void NoteOff(MidiChannel channel, int note)
	{
		if (amIInTheHitzone && note == noteNumber) {
			DestroyNote ();
		}
	}

	void DestroyNote()
	{
		Debug.Log ("Now destroying note " + noteNumber);
		Destroy (gameObject);
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
	}}
