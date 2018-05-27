using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeCollisionDetection : MonoBehaviour {

	[SerializeField] private GameObject VIVEController;
	[SerializeField] private ControllerVibration controllerVibration;

	private Vector3 latestPos;
	private float speed;
	private ScoreManager scoreManager;

	void Awake () {
		scoreManager = ScoreManager.Instance;
	}
	void Update () {
		getSpeed ();
	}

	private void getSpeed () {
		var currentPos = VIVEController.transform.position;
		speed = ((currentPos - latestPos) / Time.deltaTime).sqrMagnitude;
		latestPos = currentPos;
	}

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag ("Target") && speed > 1f) {
			controllerVibration.setVibrationTime (0.1f);
			other.gameObject.GetComponent<TargetDestroyable> ().DestroyThisObject ();
			scoreManager.addScore (100);
		}

	}
}