using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

    public bool aO = true;
    public bool aT = false;
    public bool aTh = false;
    public bool aF = false;
    public bool aFi = false;
    public bool aS = false;
    public bool aSe = false;
    public bool aE = false;
    public bool aN = false;

    public void level1() {

        print("not working");
        if (aO == true) {
            SceneManager.LoadScene("Level1");
            print("aO");
        }

    }

    public void level2()
    {

        if (aT == true)
        {
            SceneManager.LoadScene("Level2");
        }

    }
}
