using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTutorial : Tutorial {

	[SerializeField] Color fadeColor = Color.black;
	[SerializeField] float fadeTime = 1.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public override void StartTutorial () {

		StartCoroutine (DelayMethod (2f, () => {
			SteamVR_LoadLevel.Begin ("Main", false, 3.0f);
		}));

	}

	public override void EndTutorial () {
		throw new System.NotImplementedException ();
	}
}