using UnityEngine;
using LitJson;
using System.IO;
using UnityEngine.SceneManagement;

public class SavingScript : MonoBehaviour {
    
    public bool level1 = true;
    public bool level2;
    public bool level3;
    public bool level4;
    public bool level5;
    public bool level6;
    public bool level7;
    public bool level8;
    public bool level9;

    public levels levels;

    JsonData levelData;

    void Start() {
        levels = new levels(level1, level2, level3, level4, level5,
                                      level6, level7, level8, level9);
    }

    void Update() {

        if (SceneManager.GetActiveScene().name == "Level2")
        {
            level2 = true;
        }
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            level2 = true;
            level3 = true;
        }
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            level2 = true;
            level3 = true;
            level4 = true;
        }
        if (SceneManager.GetActiveScene().name == "Level5")
        {
            level2 = true;
            level3 = true;
            level4 = true;
            level5 = true;
        }
        if (SceneManager.GetActiveScene().name == "Level6")
        {
            level2 = true;
            level3 = true;
            level4 = true;
            level5 = true;
            level6 = true;
        }
        if (SceneManager.GetActiveScene().name == "Level7")
        {
            level2 = true;
            level3 = true;
            level4 = true;
            level5 = true;
            level6 = true;
            level7 = true;
        }
        if (SceneManager.GetActiveScene().name == "Level8")
        {
            level2 = true;
            level3 = true;
            level4 = true;
            level5 = true;
            level6 = true;
            level7 = true;
            level8 = true;
        }
        if (SceneManager.GetActiveScene().name == "Level9")
        {
            level2 = true;
            level3 = true;
            level4 = true;
            level5 = true;
            level6 = true;
            level7 = true;
            level8 = true;
            level9 = true;
        }
        levels = new levels(level1, level2, level3, level4, level5,
                                      level6, level7, level8, level9);
        levelData = JsonMapper.ToJson(levels);
        File.WriteAllText(Application.dataPath + "/levelData.json", 
                          levelData.ToString());


    }


}


public class levels
{

    public bool level1;
    public bool level2;
    public bool level3;
    public bool level4;
    public bool level5;
    public bool level6;
    public bool level7;
    public bool level8;
    public bool level9;


    public levels(bool level1, bool level2, bool level3, bool level4, bool level5,
              bool level6, bool level7, bool level8, bool level9) {

        this.level1 = level1;
        this.level2 = level2;
        this.level3 = level3;
        this.level4 = level4;
        this.level5 = level5;
        this.level6 = level6;
        this.level7 = level7;
        this.level8 = level8;
        this.level9 = level9;

    }

}
