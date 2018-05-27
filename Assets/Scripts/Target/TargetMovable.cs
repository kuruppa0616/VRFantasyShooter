using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovable : Movable {

	[SerializeField] private float range = 0.06f;
	void Start () {
		var xDirection = Random.Range (-range, range);
		var yDirection = Random.Range (-range, range);
		var direction = (-transform.forward) + new Vector3 (xDirection, yDirection, 0);
		Move ((direction * Random.Range (0.7f, 1.5f)));
	}

}