using UnityEngine.SceneManagement;
using UnityEngine;

public class SpikeScript : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D hit) {

        if (hit.transform.name == "Player") {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }
}
