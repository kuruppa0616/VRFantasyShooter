using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotatable : Rotatable {

	// Use this for initialization
	void Start () {
		var ramdomRotation = Random.Range (5, 10);
		Rotate(new Vector3 (ramdomRotation, ramdomRotation, 0));
	}
	
}
