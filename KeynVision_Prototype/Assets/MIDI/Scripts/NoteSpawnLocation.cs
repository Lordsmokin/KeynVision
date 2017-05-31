using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class NoteSpawnLocation : MonoBehaviour {

	public GameObject flyingNotes;
	private GameObject keyboard;

	public float startDistance;
	public Transform keySpawnPosition;
	public float spawnTime;
	private float timeToSpawn;

	// Use this for initialization
	void Start () {
		timeToSpawn = 0f;
	}
	
	// Update is called once per frame
	void Update () {

		timeToSpawn -= Time.deltaTime;

		if (timeToSpawn <= 0f) {

			GameObject noteModel = flyingNotes;
			keyboard = GameObject.FindGameObjectWithTag ("keyboard");

			float upOffset = 0.02f;

			Vector3 spawnPosition = new Vector3 (keySpawnPosition.position.x, keySpawnPosition.position.y, keySpawnPosition.position.z);
			spawnPosition += keyboard.transform.up.normalized * upOffset;
			spawnPosition += keyboard.transform.forward.normalized * startDistance;
			Instantiate (noteModel, spawnPosition, Quaternion.identity);//, gameObject.transform);

			timeToSpawn = spawnTime;

		}
	}
}