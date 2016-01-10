using UnityEngine;
using System.Collections;
using System;

public class ClockScript2 : MonoBehaviour {

	public GameObject _secondHand, _minuteHand, _hourHand;

	private void RotateByFraction(GameObject obj, float fraction) {
		Transform transform = obj.GetComponent<Transform>();
		transform.localRotation = Quaternion.Euler (0, 0, fraction * 360);
	}

	// Update is called once per frame
	void Update () {
		//convert current second to an angle then transform by setting rotation vector
		RotateByFraction (_hourHand, DateTime.Now.Hour /12f);
		RotateByFraction (_minuteHand, DateTime.Now.Minute / 60f);
		RotateByFraction (_secondHand, DateTime.Now.Second / 60f);
		//		Debug.Log(string.Format("Update called at {0} seconds", Time.time));
	}
}
