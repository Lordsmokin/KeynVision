using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class MyNoteIndicatorGroup : MonoBehaviour {
	
	public GameObject whiteNotes;
	public Transform keySpawnPosition;
	public int noteNumber;

	public float spawnTime;
	private float timeToSpawn;

	void Start()
	{
		timeToSpawn = 0f;
	
		if (MidiMaster.GetKeyDown(noteNumber))
		{
			var go = Instantiate<GameObject>(whiteNotes);
			go.transform.position = new Vector3 (keySpawnPosition.position.x, keySpawnPosition.position.y, keySpawnPosition.position.z);
			//go.GetComponent<MyNoteIndicator>().noteNumber = i;
		}
	
	}	

	void Update ()
	{
		timeToSpawn -= Time.deltaTime;
	/*
		if (MidiMaster.GetKeyDown(noteNumber) && MidiMaster.GetKeyUp(noteNumber)) {

			
			// for (var i = 0; i < 128; i++) {

				GameObject noteModel = whiteNotes;

				Vector3 spawnPosition = new Vector3 (keySpawnPosition.position.x, keySpawnPosition.position.y, keySpawnPosition.position.z);
				var go = Instantiate (noteModel, spawnPosition, Quaternion.identity);
				go.GetComponent<MyNoteIndicator>().noteNumber = ;
				go.transform.position = spawnPosition;
			}
*/
		if (MidiMaster.GetKeyDown (noteNumber)) {
			
			GameObject noteModel = whiteNotes;
			Vector3 spawnPosition = new Vector3 (keySpawnPosition.position.x, keySpawnPosition.position.y, keySpawnPosition.position.z+ 1.1f);
			Instantiate (noteModel, spawnPosition, Quaternion.identity);
		}

			timeToSpawn = spawnTime;
		}

	// }
		
}
