using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Rotatable : MonoBehaviour {

	[SerializeField] private float speed;

	[SerializeField] private Rigidbody _rigidbody;
	// Use this for initialization
	protected virtual void Rotate (Vector3 direction) {
		_rigidbody.angularVelocity = direction * speed;
	}

}