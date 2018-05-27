using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour {
	[SerializeField] private Text scoreText;
	private static ScoreManager mInstance;
	private int score;

	void Awake () {
		mInstance = ScoreManager.Instance;
	}
	public void UpdateUI () {
		scoreText.text = mInstance.getScore ().ToString ();
	}
}