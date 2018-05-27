using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    // オブジェクトを(x, y, z)すべての成分をランダムにして回転運動をさせる
    void Update () {
        if (transform.position.z <= -30) {
            Destroy (this.gameObject);
        }
    }

}