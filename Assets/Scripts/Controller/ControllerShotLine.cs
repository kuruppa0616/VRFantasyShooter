using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerShotLine : MonoBehaviour {
	[SerializeField] private LineRenderer LineRender;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 startVec = transform.position;
		Vector3 endVec = transform.forward.normalized * 100;
		LineRender.SetPosition (0, startVec);
		LineRender.SetPosition (1, endVec);
	}
}