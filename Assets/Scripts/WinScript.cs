using UnityEngine.SceneManagement;
using UnityEngine;

public class WinScript : MonoBehaviour
{

    public string SceneToLoad;
    public bool died = false;

    void OnCollisionEnter2D(Collision2D hit)
    {   
        if (hit.transform.name == "Walls") {

            died = true;

        }

        if (hit.transform.name == "Player" && !died)
            {

                SceneManager.LoadScene(SceneToLoad);

            }

    }
}
