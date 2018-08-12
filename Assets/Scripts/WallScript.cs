using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour {

    public GameObject text;
    public int isLeft = 1;
    public float speed = 0.01f;
	// Update is called once per frame
	void Update () {

        if (isLeft == 2) {

            if (Input.anyKey) {

                SceneManager.LoadScene("LevelSelect");

            }

        }
        if (isLeft == 1)
        {
            transform.position += new Vector3(speed, 0, 0);
        } else if (isLeft == 0){
            transform.position -= new Vector3(speed, 0, 0);
        }
	}

    void OnCollisionEnter2D(Collision2D hit) {


        if (hit.transform.name != "Player")
        {
            StartCoroutine(Wait()); 
        }
    }

    IEnumerator Wait() {

        yield return new WaitForSeconds(1.2f);
            isLeft = 2;
            text.SetActive(true);

        }

    }
