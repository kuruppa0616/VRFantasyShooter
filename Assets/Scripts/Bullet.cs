using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField] private float life_time = 10f;
    private float time = 0f;
    private ScoreManager scoreManager;
    private bool flag = true;

    void Awake () {
        scoreManager = ScoreManager.Instance;
        // Debug.Log(scoreManager);
    }

    void FixedUpdate () {
        time += Time.deltaTime;
        if (time > life_time) {
            Destroy (this.gameObject);
        }
    }

    void OnTriggerEnter (Collider other) {
        if (other.CompareTag ("Target")) {
            Debug.Log (other.gameObject.name);
            other.gameObject.GetComponent<TargetDestroyable> ().DestroyThisObject ();
            scoreManager.addScore (100);
        }

    }

}