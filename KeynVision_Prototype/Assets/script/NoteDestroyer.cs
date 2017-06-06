using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDestroyer : MonoBehaviour {

	public Collider noteDestroy1;
	public Collider noteDestroy2;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Destroy")) 
		{
			Destroy(other.gameObject);
		}
	}
}
