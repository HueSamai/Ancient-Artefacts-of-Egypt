using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlinkScript : MonoBehaviour {

    bool onOff = false;

	void Start () {
        StartCoroutine(Blink());
	}

    IEnumerator Blink() {

        yield return new WaitForSeconds(1f);

        blink();

        StartCoroutine(Blink());

    }

    void blink() {
        if (onOff == false)
        {
            transform.gameObject.GetComponent<Text>().text = "";
            onOff = true;
        }
        else
        {

            transform.gameObject.GetComponent<Text>().text = "Click Any Key To Play";
            onOff = false;
        }
    }
}
