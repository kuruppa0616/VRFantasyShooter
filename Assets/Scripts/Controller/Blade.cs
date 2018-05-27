using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : Weapon {

	[SerializeField] private GameObject blade;

	public override void Attack () { }

	public override void Install () {
		blade.SetActive (true);
	}

	public override void Refresh () { }

	public override void Uninstall () {
		blade.SetActive (false);
	}
}