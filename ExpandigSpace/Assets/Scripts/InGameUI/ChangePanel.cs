using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour {

    public GameObject open;
    public GameObject close;

    public void Next()
    {
        open.SetActive(true);
        close.SetActive(false);
    }
}
