using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
    public GameObject popup;
    public GameObject picture1;

    public void Close()
    {
        Time.timeScale = 1;
        popup.SetActive(false);
        //picture1.
    }
}
