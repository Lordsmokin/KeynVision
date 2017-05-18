using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalNoteSpawner : MonoBehaviour {

	public GameObject whiteNotes;
	private GameObject keyboard;

	public float startDistance;
	//public bool lessThan = true;

	//public float[] arrayNotes;
	public Transform keySpawnPosition;
	//public Transform keyFlyDirection;

	public float spawnTime;
	private float timeToSpawn;

	/*
	// Use this for initialization
	IEnumerator Start () {

		timeToSpawn = 0f;

		keyboard = GameObject.FindGameObjectWithTag ("keyboard");

		// alternative coroutine version:
		// start a coroutine but with a delay of timetospawn
		// the coroutine itself only does the for loop
		// at the end of the coroutine it reschedules iself with a delay
		yield return StartCoroutine(SpawnNotes(0f));
	}


	IEnumerator SpawnNotes(float delay) {
		yield return WaitForSeconds (delay);
		for (int index = 0; index <= 2; index++) 
		{
			GameObject noteModel = whiteNotes;
			float upOffset = 0.02f;
			Vector3 spawnPosition = new Vector3 (keySpawnPosition.position.x, keySpawnPosition.position.y, keySpawnPosition.position.z);
			spawnPosition += keyboard.transform.up.normalized * upOffset;
			spawnPosition += keyboard.transform.forward.normalized * startDistance;
			Instantiate (noteModel, spawnPosition, Quaternion.identity); //, gameObject.transform);
		}
		yield return StartCoroutine(SpawnNotes(spawnTime));
	}
	*/

	void start() {
		timeToSpawn = 0f;
	}

	// Update is called once per frame
	void Update () {

		timeToSpawn -= Time.deltaTime;

		if (timeToSpawn <= 0f) {

				GameObject noteModel = whiteNotes;
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
