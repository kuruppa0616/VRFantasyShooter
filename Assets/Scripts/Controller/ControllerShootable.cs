using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerShootable : Shootable {

	[SerializeField] private SteamVR_TrackedObject trackedObject;
	[SerializeField] private GameObject SpawnPoint;
	[SerializeField] private GameObject hitEffects;

	void Update () {
		var device = SteamVR_Controller.Input ((int) trackedObject.index);
		if (device.GetPressDown (SteamVR_Controller.ButtonMask.Trigger)) {
			Shot (SpawnPoint.transform.position, transform.rotation);
			Instantiate (hitEffects, SpawnPoint.transform.position, Quaternion.identity);

		}
	}
}