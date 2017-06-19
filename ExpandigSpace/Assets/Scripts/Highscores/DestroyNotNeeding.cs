using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNotNeeding : MonoBehaviour {

    public GameObject[] deleting;
    public GameObject[] olddeleting;
    
	void Awake () {
        deleting = GameObject.FindGameObjectsWithTag("MyScore");
        olddeleting = GameObject.FindGameObjectsWithTag("Highscoreslist");
	}
	
	public void Delete () {
        if (deleting.Length > 1)
        {
            Destroy(deleting[1]);
        }
        if (olddeleting.Length > 1)
        {
            Destroy(olddeleting[1]);
        }
	}
}
