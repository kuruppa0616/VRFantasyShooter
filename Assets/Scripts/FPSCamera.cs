using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour {
	[SerializeField] private Transform Parent;
	[SerializeField] private Transform Camera;
	[SerializeField] private GameObject bullet;

	public float speed = 1f;

	// Update is called once per frame

	void Start () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update () {
		float xRotation = Input.GetAxis ("Mouse X") * speed;
		float yRotation = Input.GetAxis ("Mouse Y") * speed;
		Parent.transform.Rotate (0f, xRotation, 0f);
		Camera.transform.Rotate (-(yRotation), 0f, 0f);
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (bullet, transform.position, transform.rotation);

		}
	}
}