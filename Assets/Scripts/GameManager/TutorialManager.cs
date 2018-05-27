using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : SingletonMonoBehaviour<TutorialManager> {
	[SerializeField] private Tutorial[] tutorials;
	private Tutorial currenTutorial;

	private int currenTutorialIdx;
	private int idx = 0;

	// Use this for initialization
	void Start () {
		currenTutorialIdx = 0;
		tutorials[currenTutorialIdx].StartTutorial ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void NextTutorial () {
		tutorials[currenTutorialIdx].EndTutorial ();
		currenTutorialIdx++;
		tutorials[currenTutorialIdx].StartTutorial ();

	}

}