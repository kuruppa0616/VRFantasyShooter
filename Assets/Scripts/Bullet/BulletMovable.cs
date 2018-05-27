using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovable : Movable {

	// Use this for initialization
	void Start () {
		Move(transform.forward.normalized);
	}
	

}
