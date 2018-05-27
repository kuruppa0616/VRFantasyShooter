using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (Rigidbody))]
public abstract class Movable : MonoBehaviour {

	[SerializeField] private float speed;

	[SerializeField] private Rigidbody _rigidbody;
	public virtual void Move (Vector3 direction) {
		_rigidbody.velocity = direction * speed;
	}
	
}