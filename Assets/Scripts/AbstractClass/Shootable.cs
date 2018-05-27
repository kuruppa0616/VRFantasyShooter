using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shootable : MonoBehaviour {
	[SerializeField]private GameObject bullet;

	protected virtual void Shot(Vector3 position,Quaternion rotation){
        Instantiate (bullet, position, rotation);
	}
}
