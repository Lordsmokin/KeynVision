using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_destroy : MonoBehaviour {

    public float speed;
    public bool greaterThan = true;
    public float yPosition;

	// Use this for initialization
	void Start () {
        Rigidbody r = GetComponent<Rigidbody>();
        r.velocity = Vector3.down * speed;
	}
	
	// Update is called once per frame
	void Update () {
        if ((greaterThan && transform.position.y > yPosition) ||
            (!greaterThan && transform.position.y < yPosition))
            Destroy(gameObject);
	}
}
