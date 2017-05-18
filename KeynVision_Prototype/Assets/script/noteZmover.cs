using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteZmover : MonoBehaviour {

	public float speed;
	public Transform keyFlyDirection;
	private GameObject keyboard;

	//public bool greaterThan = true;
	//public float zPosition;

	// Use this for initialization
	void Start () {
		keyboard = GameObject.FindGameObjectWithTag ("keyboard");
		
		Rigidbody r = GetComponent<Rigidbody> ();
		r.velocity = keyboard.transform.forward.normalized * speed * -1f;
		Vector3 targetRotation = Vector3.zero;
		targetRotation.x = keyboard.transform.rotation.eulerAngles.z;
		targetRotation.z = keyboard.transform.rotation.eulerAngles.x;
//		transform.right = keyboard.transform.forward.normalized * 1f;
//		transform.forward = keyboard.transform.right.normalized;
		transform.rotation = keyboard.transform.rotation;//Quaternion.Euler(targetRotation);
	}

	void FixedUpdate()
	{
//		Vector3 keyDirection = new Vector3 (keyFlyDirection.position.x, keyFlyDirection.position.y, keyFlyDirection.position.z);
//		Vector3 fwd = keyFlyDirection.transform.TransformDirection(keyDirection);
	}

	// Update is called once per frame

	void Update () {
/*		
		if (transform.position != keyFlyDirection.position) 
		{
			Vector3 pos = Vector3.MoveTowards(transform.position, keyFlyDirection.position, speed * Time.deltaTime);
			GetComponent<Rigidbody>().MovePosition(pos);
		}
*/
	}
		

}
