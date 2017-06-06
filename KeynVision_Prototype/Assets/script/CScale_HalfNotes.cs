using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CScale_HalfNotes : MonoBehaviour {

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
	public GameObject B_DesendSpawner;
	public GameObject A_DesendSpawner;
	public GameObject G_DesendSpawner;
	public GameObject F_DesendSpawner;
	public GameObject E_DesendSpawner;
	public GameObject D_DesendSpawner;

	void Start () {
		// Create the octave spawners:
		CreateOctave();
		//CreateOther();
	}

	void CreateOctave() {
		CreateNote ("R", 0f, 1f);
		CreateNote ("C", 4f, 34f);
		CreateNote ("D", 6f, 34f);
		CreateNote ("E", 8f, 34f);
		CreateNote ("F", 10f, 34f);
		CreateNote ("G", 12f, 34f);
		CreateNote ("A", 14f, 34f);
		CreateNote ("B", 16f, 34f);
		CreateNote ("C1",18f, 34f);
		CreateNote ("B", 20f, 34f);
		CreateNote ("A", 22f, 34f);
		CreateNote ("G", 24f, 34f);
		CreateNote ("F", 26f, 34f);
		CreateNote ("E", 28f, 34f);
		CreateNote ("D", 30f, 34f);
		CreateNote ("C", 32f, 34f);
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

