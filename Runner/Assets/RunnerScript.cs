using UnityEngine;
using System.Collections;
using System;

public class RunnerScript : MonoBehaviour {
	public event Action LandedOnPlatform = delegate{};
	public event Action FellIntoTheVoid = delegate{};
	public Vector3 Acceleration;
	public Vector3 JumpVelocity; // add this
	private bool _IsTouchingPlatform;
	void Update () {
		if (_IsTouchingPlatform && Input.GetButtonDown("Jump")) {
			this.GetComponent<Rigidbody>().AddForce(JumpVelocity,
				ForceMode.VelocityChange);
		}
		if (this.transform.position.y < -100) {
			FellIntoTheVoid.Invoke ();
		}
	}
	void FixedUpdate () {
		if (_IsTouchingPlatform) {
			this.GetComponent<Rigidbody>().AddForce(Acceleration,
				ForceMode.Acceleration);
		}
	}

	void OnCollisionEnter () {
		_IsTouchingPlatform = true;
		LandedOnPlatform.Invoke();
	}

	void OnCollisonExit() {
		_IsTouchingPlatform = false; 
	}

}