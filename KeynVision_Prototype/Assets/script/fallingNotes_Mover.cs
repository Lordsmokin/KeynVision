using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingNotes_Mover : MonoBehaviour {

	public GameObject note;
	public Transform myKey;
	public float spawnZ;
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
			Instantiate (note, new Vector3 (myKey.position.x, 0f, spawnZ), Quaternion.identity);
			timeToSpawn = spawnTime;
		}
	}	

}