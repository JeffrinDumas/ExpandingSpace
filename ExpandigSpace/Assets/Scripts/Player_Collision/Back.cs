using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
    public GameObject popup;
    public GameObject rightanwser;

    public void Close()
    {
        Time.timeScale = 1;
        popup.SetActive(false);
        rightanwser.SetActive(false);
    }
}
