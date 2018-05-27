using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestroyable : Destroyable {
	[SerializeField] private GameObject hitEffects;
	public override void DestroyThisObject () {
		Instantiate (hitEffects, transform.position, Quaternion.identity);
		Destroy (this.gameObject);

	}
}