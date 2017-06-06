using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SongSetup : MonoBehaviour {
	public UnityEvent NotesSetupCreator;

	public GameObject FlyDirections;

	public GameObject RSpawner;
	public GameObject CSpawner;
	public GameObject DSpawner;
	public GameObject ESpawner;
	public GameObject FSpawner;
	public GameObject GSpawner;
	public GameObject ASpawner;
	public GameObject BSpawner;
	public GameObject C1Spawner;

	private float startTime = 0f;

	void Start () {
		startTime = Time.realtimeSinceStartup;
		// Create the correct notes setup:
		NotesSetupCreator.Invoke();
	}

	public void CreateOctave() {
		CreateNote ("R", 0f, 1f);
		CreateNote ("C", 8f, 64f);
		CreateNote ("D", 12f, 64f);
		CreateNote ("E", 16f, 64f);
		CreateNote ("F", 20f, 64f);
		CreateNote ("G", 24f, 64f);
		CreateNote ("A", 28f, 64f);
		CreateNote ("B", 32f, 64f);
		CreateNote ("C1",36f, 64f);
		CreateNote ("B", 40f, 64f);
		CreateNote ("A", 44f, 64f);
		CreateNote ("G", 48f, 64f);
		CreateNote ("F", 52f, 64f);
		CreateNote ("E", 56f, 64f);
		CreateNote ("D", 60f, 64f);
		CreateNote ("C", 64f, 64f);

	}

	public void CreateArpeggio() {
		CreateNote ("R", 0f, 1f);
		CreateNote ("C", 8f, 32f);
		CreateNote ("E", 12f, 32f);
		CreateNote ("G", 16f, 32f);
		CreateNote ("C1",20f, 32f);
		CreateNote ("G", 24f, 32f);
		CreateNote ("E", 28f, 32f);
		CreateNote ("C", 32f, 32f);
	}

	// Notes are positioned at the end of their holding time
	void CreateNote(string note, float timeToStart, float interval) {
		GameObject spawnerPrefab = GetSpawner (note);
		Transform spawnParent = GetSpawnParent (note);
		Transform target = GetNoteTarget (note);
		// now instantiate the new spawner:
		GameObject newSpawner = Instantiate(spawnerPrefab, spawnParent, false);
		newSpawner.GetComponent<LocalNoteSpawner> ().timeToSpawn = timeToStart;
		newSpawner.GetComponent<LocalNoteSpawner> ().spawnInterval = interval;
		newSpawner.GetComponent<LocalNoteSpawner> ().keyFlyDirection = target;
		newSpawner.GetComponent<LocalNoteSpawner> ().nextEventTime = startTime;
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
		} else if (note == "R") {
			return RSpawner;
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
