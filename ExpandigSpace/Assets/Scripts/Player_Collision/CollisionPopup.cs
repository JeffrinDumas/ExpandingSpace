using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionPopup : MonoBehaviour {

    public GameObject popup;
    public Text question;
    public GameObject[] options;
    public Text[] optionstexts;
    public GameObject currentobject;
    public GameObject rightpanel;
    public GameObject wrongpanel;
    public GameObject questionpanel;
    public QuestionGiver questionGiver;
    public Question q;
    //private string[] vragen;
    //private string[] antwoorden;
    private int randomvragen;

    void Start()
    {
        /*vragen = new string[] {
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
        };*/
    }

    void OnTriggerEnter(Collider other)
    {/*
        randomvragen = Random.Range(0, 2);
       

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
        */
        if (other.tag == "Snail")
        {
            popup.SetActive(true);
            Time.timeScale = 0;
        }
        q = questionGiver.GiveQuestion();
        question.text = q.questionText;
        //Debug.Log(q.answers.Length);
        //Debug.Log(q.answers[0].correct);
        for(int i = 0; i< q.answers.Length; i++)
        {
            options[i].SetActive(true);
            optionstexts[i].text = q.answers[i].answerText;
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
