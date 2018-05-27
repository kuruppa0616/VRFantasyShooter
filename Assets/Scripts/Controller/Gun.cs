using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon {
	[SerializeField] private GameObject SpawnPoint;
	[SerializeField] private GameObject bullet;
	[SerializeField] private GameObject shotEffects;
	[SerializeField] private LineRenderer LineRender;
	[SerializeField] private ControllerVibration controllerVibration;
	public override void Attack () {
		controllerVibration.setVibrationTime (0.2f);
		Instantiate (bullet, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
		Instantiate (shotEffects, SpawnPoint.transform.position, Quaternion.identity);
	}

	public override void Install () {
		LineRender.enabled = true;
	}

	public override void Refresh () {
		Vector3 startVec = transform.position;
		Vector3 endVec = transform.forward.normalized * 100;
		LineRender.SetPosition (0, startVec);
		LineRender.SetPosition (1, endVec);
	}

	public override void Uninstall () {
		LineRender.enabled = false;
	}
}