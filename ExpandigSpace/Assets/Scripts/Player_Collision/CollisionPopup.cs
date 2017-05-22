using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionPopup : MonoBehaviour {

    public GameObject popup;
    public Text question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject option5;
    public GameObject option6;
    public Text option1text;
    public Text option2text;
    public Text option3text;
    public Text option4text;
    public Text option5text;
    public Text option6text;
    public string[] vragen;
    public string[] antwoorden;
    private int randomvragen;

    void Start()
    {
        vragen = new string[] {
            "Is de aarde een planeet?",
            "Wat is geen sterrenbeeld?"
        };
        antwoorden = new string[]
        {
            "Ja",
            "Nee",
            "boogschutter",
            "sprinkhaan",
            "slang"
        };
    }

    /*void Update()
    {
        var randomvragen = Random.Range(0, 2);
        Debug.Log(randomvragen);
    }*/

    void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        randomvragen = Random.Range(0, 2);
        //Debug.Log(randomvragen);
        if(other.tag == "Snail")
        {
            popup.SetActive(true);
        }
        switch (randomvragen)
        {
            case 0:
                question.text = vragen[0];
                option2.SetActive(true);
                option2text.text = antwoorden[0];
                option5.SetActive(true);
                option5text.text = antwoorden[1];
                break;
            case 1:
                question.text = vragen[1];
                option1.SetActive(true);
                option1text.text = antwoorden[2];
                option2.SetActive(true);
                option2text.text = antwoorden[3];
                option3.SetActive(true);
                option3text.text = antwoorden[4];
                break;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Time.timeScale = 1;
    }
}
