using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionPopup : MonoBehaviour {

    public GameObject popup;
    public Text question;
    public GameObject[] options;
    public Text[] optionstexts;
    private string[] vragen;
    private string[] antwoorden;
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

    void OnTriggerEnter(Collider other)
    {
        randomvragen = Random.Range(0, 2);
        if (other.tag == "Snail")
        {
            popup.SetActive(true);
            Time.timeScale = 0;
        }

        switch (randomvragen)
        {
            case 0:
                question.text = vragen[0];
                options[1].SetActive(true);
                optionstexts[1].text = antwoorden[0];
                options[4].SetActive(true);
                optionstexts[4].text = antwoorden[1];
                break;
            case 1:
                question.text = vragen[1];
                options[0].SetActive(true);
                optionstexts[0].text = antwoorden[2];
                options[1].SetActive(true);
                optionstexts[1].text = antwoorden[3];
                options[2].SetActive(true);
                optionstexts[2].text = antwoorden[4];
                break;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Time.timeScale = 1;
        for(int i = 0; i < options.Length; i++)
        {
            options[i].SetActive(false);
        }
    }
}
