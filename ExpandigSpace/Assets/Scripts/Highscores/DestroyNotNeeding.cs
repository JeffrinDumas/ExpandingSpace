using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNotNeeding : MonoBehaviour {

    public GameObject deleting;
    public GameObject[] olddeleting;
    
	void Awake () {
        deleting = GameObject.FindGameObjectWithTag("MyScore") as GameObject;
        olddeleting = GameObject.FindGameObjectsWithTag("Highscoreslist");
	}
	
	public void Delete () {
        Destroy(deleting);
        if(olddeleting.Length > 1)
        {
            Destroy(olddeleting[1]);
        }
	}
}
