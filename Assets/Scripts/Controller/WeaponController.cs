using System.Collections;
using System.Collections.Generic;
using HTC.UnityPlugin.Vive;
using UnityEngine;

public class WeaponController : MonoBehaviour {
	[SerializeField] private Weapon[] Weapon;
	[SerializeField] private Rigidbody _rigidbody;
	[SerializeField] private WeaponView weaponView;
	[SerializeField] private WeaponType weaponType;
	[SerializeField] private GameObject SwitchEffect;
	[SerializeField] private ControllerVibration controllerVibration;

	private int currentWeaponIdx;
	private int idx = 0;

	// Use this for initialization
	void Start () {
		currentWeaponIdx = 0;
		weaponType = WeaponType.GUN;
		Weapon[currentWeaponIdx].Install ();
	}
	void Update () {

		if (ViveInput.GetPressDown (HandRole.RightHand, ControllerButton.Pad)) {
			SwitchWeapon ();
		}

		Weapon[currentWeaponIdx].Refresh ();
		if (ViveInput.GetPressDown (HandRole.RightHand, ControllerButton.Trigger)) {
			Weapon[currentWeaponIdx].Attack ();
		}

	}

	private void SwitchWeapon () {

		controllerVibration.setVibrationTime (0.1f);
		Instantiate (SwitchEffect, transform.position, transform.rotation);

		Weapon[currentWeaponIdx].Uninstall ();

		currentWeaponIdx = ++idx % Weapon.Length;
		if (weaponType == WeaponType.GUN) {
			weaponType = WeaponType.SWORD;
		} else if (weaponType == WeaponType.SWORD) {
			weaponType = WeaponType.GUN;
		}

		weaponView.changeUI ();
		Weapon[currentWeaponIdx].Install ();

	}
	public WeaponType getWeaponType () {
		return weaponType;
	}
}