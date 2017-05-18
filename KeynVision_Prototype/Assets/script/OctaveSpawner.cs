using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctaveSpawner : MonoBehaviour {

	public GameObject whiteNotes;
	public GameObject blackNotes;

	public float startDistance;
	public float distanceBetween;
	public bool lessThan = true;
	//public Collider destroyNote;

	public float[] arrayNotes;
	public Transform[] keySpawnPosition;

	public float spawnTime;
	private float timeToSpawn;
	private List<int> blackNoteIndices = new List<int> {1,4,6,9,11};

	// Use this for initialization
	void Start () {
		
		timeToSpawn = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		
		timeToSpawn -= Time.deltaTime;

		if (timeToSpawn <= 0f) {
			
			for (int index = 0; index <= 11; index++) 
			{
				
				GameObject noteModel = whiteNotes;

				float upOffset = 0.02f;

				if (blackNoteIndices.Contains (index)) 
				{
					noteModel = blackNotes;
					upOffset = 0.015f;
				}

				Vector3 spawnPosition = new Vector3 (keySpawnPosition[index].position.x, keySpawnPosition[index].position.y + upOffset, startDistance + (distanceBetween * index));
				Instantiate (noteModel, spawnPosition, Quaternion.identity);
			}

			timeToSpawn = spawnTime;
		}

	}


}
