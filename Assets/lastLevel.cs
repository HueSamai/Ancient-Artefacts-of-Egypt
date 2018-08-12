using UnityEngine;
using UnityEngine.SceneManagement;

public class lastLevel : MonoBehaviour {

    public GameObject player;

    void Update() {

        if (player.transform.position.y >= transform.position.y+1) {


            transform.position += new Vector3(0, 0.1f, 0);
        }
        if (player.transform.position.y <= transform.position.y - 4.5f)
        {
            SceneManager.LoadScene("Level9");
        }

        if (player.transform.position.y >= 21) {

            SceneManager.LoadScene("Win");

        }

    }
}
