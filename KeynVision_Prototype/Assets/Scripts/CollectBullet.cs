using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBullet : MonoBehaviour {

	public AudioClip collect;

	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		GetComponent<AudioSource> ();
	}
}
