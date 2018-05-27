using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScaleAnim : MonoBehaviour {

	// Use this for initialization
	private Vector3 origScale;
	void Start () {
		origScale = transform.localScale;
		transform.localScale = transform.localScale / 5;
		iTween.ScaleTo (this.gameObject, origScale, 10f);

	}

	// Update is called once per frame
	void Update () { }
}