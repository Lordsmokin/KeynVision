using UnityEngine;

public class KeyboardCommands : MonoBehaviour {

	// Called by GazeGestureManager when the user performs a Select gesture
	void OnSelect()
	{
		// If the keyboard has no Rigidbody component, add one to enable physics.
		if (!this.GetComponent<Rigidbody>())
		{
			var rigidbody = this.gameObject.AddComponent<Rigidbody>();
			rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
		}
	}
}
