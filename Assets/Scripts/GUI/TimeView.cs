using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeView : MonoBehaviour {

	[SerializeField] private Image image;
	private float RestrictionTime;
	private static TimeManager mInstance;
	void Awake () {
		mInstance = TimeManager.Instance;
	}
	private void Start () {
		RestrictionTime = mInstance.getRestrictionTime ();
	}
	public void UpdateUI () {
		float temp = mInstance.getcurrentTime () / RestrictionTime;
		image.fillAmount = 1 - temp;
	}
}