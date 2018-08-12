using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginScript : MonoBehaviour {

	void Update () {
		
        if (Input.anyKey) {

            SceneManager.LoadScene("LevelSelect");
        }

	}
}
