using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMovement : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// transform.Rotate(new Vector3(
		// 	Input.GetAxis("Vertical"),
		// 	Input.GetAxis("Horizontal"),
		// 	0
		// ));
		transform.eulerAngles += new Vector3(
			Input.GetAxis("Vertical"),
			Input.GetAxis("Horizontal"),
			0
		);
	}
}
