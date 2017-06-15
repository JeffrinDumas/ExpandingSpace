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
    public QuestionGiver questionGiver;
    public Slidertimer time;
    // Use this for initialization
    void Start()
    {
        congrats.text = "Goed gedaan je hebt het goed";
        whatnow.text = "Je hebt een nieuw onderdeel breng het snel naar het ruimteschip";
        wrong.text = "Helaas je hebt het fout";
        what.text = "Je hebt wel het onderdeel gekregen maar wel een minuut aftrek";
    }

    public void Click(int index)
    {
        if (popup.q.answers[index].correct == true)
        {
            popup.currentobject[popup.ObjectNum].SetActive(true);
            popup.rightpanel.SetActive(true);
            popup.questionpanel.SetActive(false);
            popup.score += 10;
        }
        else if (popup.q.answers[index].correct == false)
        {
            popup.wrongpanel.SetActive(true);
            popup.currentobject[popup.ObjectNum].SetActive(true);
            popup.questionpanel.SetActive(false);
            time.mainslider.value -= 60;
            popup.score -= 10;
        }
        popup.Inventoryfull = true;
    }
}
