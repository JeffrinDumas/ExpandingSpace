using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertValues : MonoBehaviour {

    public Slider currenttime;
    public CollisionPopup currentscore;
    public SaveMyScore save;
    public GameObject startvalues;

    void Start()
    {
        startvalues = GameObject.FindGameObjectWithTag("MyScore");
        save = startvalues.GetComponent<SaveMyScore>();
    }

	void Update () {
        save.time = currenttime.value;
        save.score = currentscore.score;
	}
}
