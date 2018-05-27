using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour {

	[SerializeField] private Sprite gunIcon;
	[SerializeField] private Sprite swordIcon;
	[SerializeField] private Image image;
	[SerializeField] private WeaponController weaponController;

	// Use this for initialization
	void Start () {
		image.sprite = gunIcon;
	}

	public void changeUI () {
		WeaponType weaponType = weaponController.getWeaponType ();
		if (weaponType == WeaponType.GUN) {
			image.sprite = gunIcon;
		}
		if (weaponType == WeaponType.SWORD) {
			image.sprite = swordIcon;
		}

	}
}