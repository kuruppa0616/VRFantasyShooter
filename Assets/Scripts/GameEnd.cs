using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour {

	// Use this for initialization
	private static TimeManager mInstance;

	void Awake () {
		mInstance = TimeManager.Instance;
	}

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (mInstance.getcurrentTime () >=mInstance.getRestrictionTime()) {
			StartCoroutine (DelayMethod (2f, () => {
				SteamVR_LoadLevel.Begin ("Result", false, 3.0f);
			}));
		}
	}
	protected IEnumerator DelayMethod (float waitTime, Action action) {
		yield return new WaitForSeconds (waitTime);
		action ();
	}
}