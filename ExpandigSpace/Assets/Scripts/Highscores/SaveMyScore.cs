using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMyScore : MonoBehaviour {

    public string name;
    public float time;
    public int score;

	void Awake () {
        DontDestroyOnLoad(this);
	}
}
