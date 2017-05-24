using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public CollisionPopup popup;
    public Text congrats;
    public Text whatnow;
    public Text wrong;
    public Text what;
    //public Button[] buttons;
    public QuestionGiver questionGiver;
    public Slidertimer time;
    // Use this for initialization
    void Start()
    {
        congrats.text = "Goed gedaan je hebt het goed";
        whatnow.text = "Je hebt een nieuw onderdeel breng het snel naar het ruimteschip";
        wrong.text = "Helaas je hebt het fout";
        what.text = "Je hebt wel het onderdeel gekregen maar wel een minuut aftrek";
        /*for (int i = 0; i < buttons.Length; i++)
        {
            int capturedIterator = i;
            buttons[i].onClick.AddListener(() => DoSomething(capturedIterator));
        }
    }

    public void DoSomething(int index)
    {
        Debug.Log(buttons[index]);
    }*/
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Click(int index)
    {
        if (popup.q.answers[index].correct == true)
        {
            popup.currentobject.SetActive(true);
            popup.rightpanel.SetActive(true);
            popup.questionpanel.SetActive(false);
        }
        else if (popup.q.answers[index].correct == false)
        {
            popup.wrongpanel.SetActive(true);
            popup.currentobject.SetActive(true);
            popup.questionpanel.SetActive(false);
            time.mainslider.value -= 60;
        }
    }
}
