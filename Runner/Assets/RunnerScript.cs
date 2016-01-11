using UnityEngine;
using System.Collections;

public class RunnerScript : MonoBehaviour {
	public Vector3 Acceleration;
	private bool _IsTouchingPlatform;
	void Update () {
	}

	void FixedUpdate() {
		if (_IsTouchingPlatform) {
			var rigidbody = this.GetComponent<Rigidbody> ();
			rigidbody.AddForce (Acceleration, ForceMode.Acceleration);
		}

	}

	void OnCollisionEnter () {
		_IsTouchingPlatform = true;
	}

	void OnCollisonExit() {
		_IsTouchingPlatform = false; 
	}

}