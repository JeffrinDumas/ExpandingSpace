using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertValues : MonoBehaviour {

    public Slider currenttime;
    public CollisionPopup currentscore;
    public SaveMyScore save;
	// Update is called once per frame
	void Update () {
        save.time = currenttime.value;
        save.score = currentscore.score;
        save.name = "The Legend";
	}
}
