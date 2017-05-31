using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalNoteSpawner : MonoBehaviour {

	public GameObject whiteNotes;
	public Transform keyFlyDirection;
	public float spawnInterval = 8f;
	public float timeToSpawn = 0f;

	void Update () {
		timeToSpawn -= Time.deltaTime;
		if (timeToSpawn <= 0f) {
			GameObject instantiatedNote = Instantiate (whiteNotes, transform.position, Quaternion.identity) as GameObject;
			instantiatedNote.GetComponent<simpleZmover>().keyFlyDirection = keyFlyDirection;
			if (spawnInterval > 0f) {
				timeToSpawn = spawnInterval;
			}
		}
	}
		
}
