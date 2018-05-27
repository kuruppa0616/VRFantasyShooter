using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingController : MonoBehaviour {

	public Transform m_target = null;
	public float m_speed = 5;
	public float m_attenuation = 0.5f;

	private Vector3 m_velocity;
	private Quaternion m_rotate;

	private void Update () {
		m_velocity += (m_target.position - transform.position) * m_speed;
		m_velocity *= m_attenuation;
		transform.position += m_velocity *= Time.deltaTime;

		// m_rotate += transform.rotation * m_speed;
		transform.rotation=Quaternion.Slerp(transform.rotation,m_target.transform.rotation,m_speed);

	}
}