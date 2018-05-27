using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : SingletonMonoBehaviour<TimeManager> {
	[SerializeField] private float RestrictionTime;
	[SerializeField] private TimeView timeView;
	private float currentTime = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		setCurrentTime (currentTime + Time.deltaTime);

	}

	public float getRestrictionTime () {
		return RestrictionTime;
	}
	public float getcurrentTime () {
		return currentTime;
	}
	public void setCurrentTime (float temp) {
		currentTime = temp;
		NotifyObservers ();
	}
	private void NotifyObservers () {
		timeView.UpdateUI ();
	}
}