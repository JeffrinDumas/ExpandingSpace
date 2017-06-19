using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeName : MonoBehaviour {

    public GameObject startvalues;
    public SaveMyScore save;
    public InputField myname;

    // Use this for initialization
    void Start () {
		startvalues = GameObject.FindGameObjectWithTag("MyScore");
        save = startvalues.GetComponent<SaveMyScore>();
    }
	
	// Update is called once per frame
	void Update () {
        save.name = myname.text;
	}
}
