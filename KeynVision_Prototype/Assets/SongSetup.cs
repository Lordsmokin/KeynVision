using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongSetup : MonoBehaviour {

	public GameObject FlyDirections;

	public GameObject CSpawner;
	public GameObject DSpawner;
	public GameObject ESpawner;
	public GameObject FSpawner;
	public GameObject GSpawner;
	public GameObject ASpawner;
	public GameObject BSpawner;
	public GameObject C1Spawner;

	void Start () {
		// Create the octave spawners:
		//CreateOctave();
		CreateOther();
	}

	void CreateOctave() {
		CreateNote ("C", 0f, 8f);
		CreateNote ("D", 1f, 8f);
		CreateNote ("E", 2f, 8f);
		CreateNote ("F", 3f, 8f);
		CreateNote ("G", 4f, 8f);
		CreateNote ("A", 5f, 8f);
		CreateNote ("B", 6f, 8f);
		CreateNote ("C1", 7f, 8f);
	}

	void CreateOther() {
		CreateNote ("C", 0f, 8f);
		CreateNote ("E", 1f, 8f);
		CreateNote ("G", 2f, 8f);
		CreateNote ("E", 3f, 8f);
		CreateNote ("C", 4f, 8f);
		CreateNote ("B", 5f, 8f);
		CreateNote ("A", 6f, 8f);
		CreateNote ("C", 7f, 8f);
	}

	void CreateNote(string note, float timeToStart, float interval) {
		GameObject spawnerPrefab = GetSpawner (note);
		Transform spawnParent = GetSpawnParent (note);
		Transform target = GetNoteTarget (note);
		// now instantiate the new spawner:
		GameObject newSpawner = Instantiate(spawnerPrefab, spawnParent, false);
		newSpawner.GetComponent<LocalNoteSpawner> ().timeToSpawn = timeToStart;
		newSpawner.GetComponent<LocalNoteSpawner> ().spawnInterval = interval;
		newSpawner.GetComponent<LocalNoteSpawner> ().keyFlyDirection = target;
	}

	GameObject GetSpawner(string note) {
		if (note == "C") {
			return CSpawner;
		} else if (note == "D") {
			return DSpawner;
		} else if (note == "E") {
			return ESpawner;
		} else if (note == "F") {
			return FSpawner;
		} else if (note == "G") {
			return GSpawner;
		} else if (note == "A") {
			return ASpawner;
		} else if (note == "B") {
			return BSpawner;
		} else if (note == "C1") {
			return C1Spawner;
		}
		return null;
	}

	Transform GetSpawnParent(string note) {
		return transform.FindChild (note).transform;
	}

	Transform GetNoteTarget(string note) {
		return FlyDirections.transform.FindChild (note + "-FlyDirection").transform;
	}
}
