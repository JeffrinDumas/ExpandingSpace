using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionPopup : MonoBehaviour {
    public Vector3 currentPos;

    public Text question;
    public Text Scoretext;
    public Text[] optionstexts;

    public QuestionGiver questionGiver;
    public Question q;
    public GravityAttractor gravy;
    
    public bool Inventoryfull = false;
    public bool bluekey = false;
    public bool greenkey = false;
    public bool redkey = false;
 
    public int ObjectNum = 0;
    public int score = 0;
    private int randomvragen;

    public GameObject popup;
    public GameObject rightpanel;
    public GameObject wrongpanel;
    public GameObject questionpanel;
    public GameObject target;
    public GameObject[] blueHouseParts;
    public GameObject[] greenHouseParts;
    public GameObject[] redHouseParts;
    public GameObject[] currentobject;
    public GameObject[] objTaken;
    public GameObject[] options;

    public Animator anim;

    void Update()
    {
        if (objTaken[2].GetComponent<Image>().color == Color.white)
        {
            SceneManager.LoadScene(3);
        }
        Scoretext.text = "Score: " + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KeyBlue")
        {
            score += 5;
            Destroy(other.gameObject);
            bluekey = true;
        }
        if (other.tag == "KeyGreen")
        {
            score += 5;
            Destroy(other.gameObject);
            greenkey = true;
        }
        if (other.tag == "KeyRed")
        {
            score += 5;
            Destroy(other.gameObject);
            redkey = true;
        }

      

      if (other.tag == "Ship")
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
                score += 5;
            }
        }

        if (other.tag == "Snail" && Inventoryfull == false) 
        {
            q = questionGiver.GiveQuestion();
            question.text = q.questionText;
            popup.SetActive(true);
            Time.timeScale = 0;
        }

        for (int i = 0; i < options.Length; i++)
        {
            options[i].SetActive(false);
            optionstexts[i].text = "";
        }

        for (int i = 0; i< q.answers.Length; i++)
        {
            options[i].SetActive(true);
            optionstexts[i].text = q.answers[i].answerText;
        }
        if (other.tag == "Snail")
        {
            if (Inventoryfull == false)
            {
                other.enabled = false;
            }
        }
        if (other.tag == "DoorBlue" && bluekey == true)
        {
            for (int i = 0; i < blueHouseParts.Length; i++)
            {
                Destroy(blueHouseParts[i].gameObject);
            }
        }
        if (other.tag == "DoorGreen" && greenkey == true)
        {
            for (int i = 0; i < greenHouseParts.Length; i++)
            {
                Destroy(greenHouseParts[i].gameObject);
            }
        }
        if (other.tag == "DoorRed" && redkey == true)
        {
            for (int i = 0; i < redHouseParts.Length; i++)
            {
                Destroy(redHouseParts[i].gameObject);
            }
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
