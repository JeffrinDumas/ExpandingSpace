using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosepanels : MonoBehaviour {

    public GameObject Open;
    public GameObject Close;

    public void Instucties()
    {
        Open.SetActive(true);
        Close.SetActive(false);
    }
}
