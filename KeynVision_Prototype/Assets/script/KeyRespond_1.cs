using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRespond_1 : MonoBehaviour {

    public GameObject key;
    public float spawnX;
    public float spawnY;
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

        if (timeToSpawn <= 0f)
        {
            Instantiate(key, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
            timeToSpawn = spawnTime;
        }
	}
}
