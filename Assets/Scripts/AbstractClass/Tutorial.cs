using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tutorial : MonoBehaviour {

	// Use this for initialization
	protected static TutorialManager mInstance;
	void Awake () {
		mInstance = TutorialManager.Instance;
	}
	public abstract void StartTutorial ();

	public abstract void EndTutorial ();
	protected IEnumerator DelayMethod (float waitTime, Action action) {
		yield return new WaitForSeconds (waitTime);
		action ();
	}
}