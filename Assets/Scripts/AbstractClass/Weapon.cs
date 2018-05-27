using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {
	void Awake () {
		Uninstall ();
	}
	public abstract void Attack ();
	public abstract void Refresh ();
	public abstract void Install ();
	public abstract void Uninstall ();

}