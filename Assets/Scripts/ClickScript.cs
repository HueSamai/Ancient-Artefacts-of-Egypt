using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickScript : MonoBehaviour {

    public string SceneToLoad;
    public bool unlocked;
	
    void Update () {

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(
            Input.mousePosition), Vector2.zero);
        
        if (Input.GetMouseButtonDown(0))
        {
            print(hit.transform.name);
            
            if (hit.transform.name == transform.name)
            {
                print(hit.transform.name);
                if (unlocked == true)
                {
                    SceneManager.LoadScene(SceneToLoad);
                }
            }
        }

    }
}
