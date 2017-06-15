using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slidertimer : MonoBehaviour {
    public Slider mainslider;
    private float timer;
    private float runningtime;
	// Use this for initialization
	void Start () {
        mainslider.value = mainslider.maxValue;
        timer = 60;
        runningtime = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(runningtime >= timer)
        {
            mainslider.value -= 1;
            runningtime = 0;
        } else
        {
            runningtime += Time.deltaTime*60;
        }

        if(mainslider.value == 0)
        {
            SceneManager.LoadScene(4);
        }
	}
}
