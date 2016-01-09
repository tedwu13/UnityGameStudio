using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.log(string.Format("Start called at {0} seconds", Time.time));
	}
	
	// Update is called once per frame
	void Update () {
		Debug.log(string.Format("Update called at {0} seconds", Time.time));
	}
}
