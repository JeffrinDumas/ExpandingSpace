﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionPopup : MonoBehaviour {

    public GameObject popup;
    public Text question;
    public GameObject[] options;
    public Text[] optionstexts;
    public GameObject[] currentobject;
    public GameObject[] objTaken;
    public GameObject rightpanel;
    public GameObject wrongpanel;
    public GameObject questionpanel;
    public QuestionGiver questionGiver;
    public Question q;
    public int ObjectNum = 0;
    public bool Inventoryfull = false;
    private int randomvragen;

    void Update()
    {
        if (objTaken[2].GetComponent<Image>().color == Color.white)
        {
            SceneManager.LoadScene(2);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Finish")
        {
            if (Inventoryfull == true)
            {
                switch (ObjectNum)
                {


                    case 0:
                        currentobject[0].SetActive(false);
                        objTaken[0].GetComponent<Image>().color = Color.white;
                        break;
                    case 1:
                        currentobject[1].SetActive(false);
                        objTaken[1].GetComponent<Image>().color = Color.white;
                        break;
                    case 2:
                        currentobject[2].SetActive(false);
                        objTaken[2].GetComponent<Image>().color = Color.white;
                        break;
                }
                ObjectNum++;
                Inventoryfull = false;
            }
            else
            {

            }
        }

        if (other.tag == "Snail" && Inventoryfull == false) 
        {
            popup.SetActive(true);
            Time.timeScale = 0;
        }
        q = questionGiver.GiveQuestion();
        question.text = q.questionText;
       
        for(int i = 0; i< q.answers.Length; i++)
        {
            options[i].SetActive(true);
            optionstexts[i].text = q.answers[i].answerText;
        }
        if (other.tag == "Snail")
        {
            if (Inventoryfull == false)
            {
                Destroy(other);
            }
<<<<<<< HEAD
=======

>>>>>>> 460e9610b073286d5983c4ce4d2de34dbf569a9b
        }
    }

    void OnTriggerExit(Collider other)
    {
        Time.timeScale = 1;
        for(int i = 0; i < options.Length; i++)
        {
            options[i].SetActive(false);
        }
<<<<<<< HEAD
=======
      
        Debug.Log(Inventoryfull);
        Debug.Log(ObjectNum);
>>>>>>> 460e9610b073286d5983c4ce4d2de34dbf569a9b
    }
}
