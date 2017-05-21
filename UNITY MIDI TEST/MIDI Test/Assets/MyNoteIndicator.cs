using UnityEngine;
using MidiJack;

public class MyNoteIndicator : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}

	public int noteNumber;

	// Update is called once per frame
	void Update () {
		Rigidbody r = GetComponent<Rigidbody> ();
		r.velocity = Vector3.forward * speed;

		//transform.localScale = Vector3.one * (1f + MidiMaster.GetKey(noteNumber));

	}
}
