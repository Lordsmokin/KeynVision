using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalNoteSpawner : MonoBehaviour {

	public GameObject whiteNotes;
	public Transform keyFlyDirection;
	public float spawnInterval = 8f;
	public float timeToSpawn = 0f;
	public float nextEventTime = 0f;

	void Update () {
		float currentTime = Time.realtimeSinceStartup;
		if (nextEventTime < currentTime) {
			if (timeToSpawn > 0f) {
				nextEventTime = nextEventTime + timeToSpawn;
				timeToSpawn = 0f;
				while (nextEventTime < currentTime && spawnInterval > 0f) {
					nextEventTime = nextEventTime + spawnInterval;
				}
			} else {
				GameObject instantiatedNote = Instantiate (whiteNotes, transform.position, Quaternion.identity) as GameObject;
				instantiatedNote.GetComponent<simpleZmover> ().keyFlyDirection = keyFlyDirection;
				if (spawnInterval > 0f) {
					timeToSpawn = spawnInterval;
				} else {
					nextEventTime = float.MaxValue;
				}
			}
		}
	}
		
}
