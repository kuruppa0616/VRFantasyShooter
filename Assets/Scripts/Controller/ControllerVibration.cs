using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerVibration : MonoBehaviour {

	private float VibrationTime;
	[SerializeField] private SteamVR_TrackedObject trackedObject;

	// Update is called once per frame
	void FixedUpdate () {

		if (VibrationTime > 0) {
			VibrationTime -= Time.deltaTime;
			//振動させる
			var device = SteamVR_Controller.Input ((int) trackedObject.index);
			device.TriggerHapticPulse (2000);
		} else {
			VibrationTime = 0;
		}
	}

	public void setVibrationTime (float time) {
		VibrationTime = Mathf.Min (VibrationTime + time, 1);
	}
}