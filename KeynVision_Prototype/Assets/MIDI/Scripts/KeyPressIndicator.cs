using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;


public class KeyPressIndicator : MonoBehaviour {
	public int noteNumber;

	void NoteOn(MidiChannel channel, int note, float velocity)
	{
		if (note == noteNumber) { // highlight
			transform.GetChild(0).gameObject.SetActive(true);
		}
	}

	void NoteOff(MidiChannel channel, int note)
	{
		if (note == noteNumber) { // reset highlight
			transform.GetChild(0).gameObject.SetActive(false);
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
