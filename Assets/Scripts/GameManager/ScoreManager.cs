using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {

	[SerializeField] private ScoreView scoreView;
	private int score = 0;

	void Start () {
		// DontDestroyOnLoad(this);
	}
	public void addScore (int socre) {
		this.setScore (this.getScore () + socre);
	}

	public void subScore (int score) {
		this.setScore (this.getScore () - score);
	}

	public void setScore (int score) {
		this.score = Mathf.Max (0, score);
		this.NotifyObservers ();
	}

	public int getScore () {
		return score;
	}

	private void NotifyObservers () {
		scoreView.UpdateUI ();
	}

}