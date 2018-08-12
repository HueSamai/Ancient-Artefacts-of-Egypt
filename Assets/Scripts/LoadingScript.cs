using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour {

    private string data;
    private JsonData jsonData;
    public SavingScript script;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;

    void Awake() {

        data = File.ReadAllText(Application.dataPath + "/levelData.json");
        jsonData = JsonMapper.ToObject(data);

        script.level2 = (bool)jsonData["level2"];
        script.level3 = (bool)jsonData["level3"];
        script.level4 = (bool)jsonData["level4"];
        script.level5 = (bool)jsonData["level5"];
        script.level6 = (bool)jsonData["level6"];
        script.level7 = (bool)jsonData["level7"];
        script.level8 = (bool)jsonData["level8"];
        script.level9 = (bool)jsonData["level9"];


    }

    void Update() {
        if (SceneManager.GetActiveScene().name == "LevelSelect")
        {
            if (script.level2 == true)
            {

                GameObject.Find("level2").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level2").GetComponent<SpriteRenderer>().sprite = sprite2;

            }
            if (script.level3 == true)
            {

                GameObject.Find("level3").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level3").GetComponent<SpriteRenderer>().sprite = sprite3;

            }
            if (script.level4 == true)
            {

                GameObject.Find("level4").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level4").GetComponent<SpriteRenderer>().sprite = sprite4;

            }
            if (script.level5 == true)
            {

                GameObject.Find("level5").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level5").GetComponent<SpriteRenderer>().sprite = sprite5;

            }
            if (script.level6 == true)
            {

                GameObject.Find("level6").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level6").GetComponent<SpriteRenderer>().sprite = sprite6;

            }
            if (script.level7 == true)
            {

                GameObject.Find("level7").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level7").GetComponent<SpriteRenderer>().sprite = sprite7;

            }
            if (script.level8 == true)
            {

                GameObject.Find("level8").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level8").GetComponent<SpriteRenderer>().sprite = sprite8;

            }
            if (script.level9 == true)
            {

                GameObject.Find("level9").GetComponent<ClickScript>().unlocked = true;
                GameObject.Find("level9").GetComponent<SpriteRenderer>().sprite = sprite9;

            }
        }
    }


}
