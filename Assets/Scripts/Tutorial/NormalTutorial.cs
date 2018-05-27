using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTutorial : Tutorial {

    [SerializeField] private GameObject TutorialObject;
    [SerializeField] private GameObject[] TriggerObject;
    private GameObject InstantiatedObject;
    private bool isRunningThisTutorial = false;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (isRunningThisTutorial && InstantiatedObject!=null) {
            var objs = InstantiatedObject.GetComponentsInChildren<Target> ();
            if (objs.Length == 0) {
                mInstance.NextTutorial ();
            }
        }
    }
    public override void StartTutorial () {
        StartCoroutine (DelayMethod (1f, () => {
            InstantiatedObject = Instantiate (TutorialObject, transform.position, transform.rotation);
            isRunningThisTutorial = true;
        }));

    }

    public override void EndTutorial () {
        Destroy (InstantiatedObject);
    }
}