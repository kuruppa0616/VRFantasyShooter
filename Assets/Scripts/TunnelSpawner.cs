using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawner : MonoBehaviour {

	[SerializeField] private GameObject tunnnel;

	// Use this for initialization
	void Start () {
		StartCoroutine (loop ());
	}

	// Update is called once per frame
	void Update () {

	}
	private IEnumerator loop () {
		// ループ
		while (true) {
			InstantiateTarget ();

			yield return new WaitForSeconds (5f);
		}

	}
	private void InstantiateTarget () {
		//生成
		Instantiate (tunnnel, transform.position, transform.rotation);

	}
}