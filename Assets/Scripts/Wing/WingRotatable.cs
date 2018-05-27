using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingRotatable : Rotatable {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Rotate (new Vector3 (0, 1, 0));
	}
}