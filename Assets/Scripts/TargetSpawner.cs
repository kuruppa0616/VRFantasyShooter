using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour {

    [SerializeField] private GameObject[] TargetObjects;
    private int targetCount = 0;
    private float RestrictionTime;
    private static TimeManager mInstance;
    private float max = 1;
    private float min = 0;

    // Use this for initialization
    void Awake () {
        mInstance = TimeManager.Instance;
    }
    void Start () {
        RestrictionTime = mInstance.getRestrictionTime ();
        StartCoroutine (loop ());
    }

    // Update is called once per frame
    void Update () {

    }

    private IEnumerator loop () {
        // ループ
        while (true) {
            if (isSpawn ()) {
                InstantiateTarget ();
            }
            yield return new WaitForSeconds (0.05f);
        }

    }

    private void InstantiateTarget () {

        Vector3 randomPos = Random.insideUnitSphere * 3;
        Vector3 spwanPosition = new Vector3 (randomPos.x, randomPos.y, transform.position.z);
        float scale = Mathf.Abs (Random.Range (0.7f, 1f));
        Vector3 spwanScale = new Vector3 (scale, scale, scale) * 1.4f;
        //生成
        GameObject gameObject = Instantiate (TargetObjects[Random.Range (0, TargetObjects.Length)], spwanPosition, transform.rotation);
        gameObject.transform.localScale = spwanScale;

    }

    private bool isSpawn () {
        float currentTime = mInstance.getcurrentTime ();
        float threshold = InOutCubic (currentTime);
        threshold = Mathf.Lerp (0.03f, 0.6f, threshold);
        float ramdom = Random.Range (min, max);
        if (ramdom <= threshold) {
            return true;
        }
        return false;
    }

    private float InOutCubic (float t) {
        t /= RestrictionTime;
        t *= 2;
        if (t < 1) {
            return 0.5f * t * t * t;
        } else {
            t -= 2;
            return 0.5f * (t * t * t + 2);
        }
    }
}