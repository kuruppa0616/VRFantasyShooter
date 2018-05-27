using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viveController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float distance = 100; // 飛ばす&表示するRayの長さ
        float duration = 0.1f;   // 表示期間（秒）

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, duration, false);

    }
}
