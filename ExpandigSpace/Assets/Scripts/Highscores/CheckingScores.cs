using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckingScores : MonoBehaviour {

    public Text[] TheHighScores;

    public GameObject MyScore;
    public GameObject CurrentHighScore;
    public SaveMyScore scriptMyScore;
    public Highscoreslist scriptCurrentHighScore;

	void Start () {
        MyScore = GameObject.FindGameObjectWithTag("MyScore") as GameObject;
        CurrentHighScore = GameObject.FindGameObjectWithTag("Highscoreslist") as GameObject;
        scriptMyScore = MyScore.GetComponent<SaveMyScore>();
        scriptCurrentHighScore = CurrentHighScore.GetComponent<Highscoreslist>();

        for (var i = 0; i < scriptCurrentHighScore.scores.Length; i++)
        {
            if (scriptMyScore.score == scriptCurrentHighScore.scores[i])
            {
                if (scriptMyScore.time > scriptCurrentHighScore.times[i])
                {
                    for (var j = scriptCurrentHighScore.times.Length - 1; j != i; j--)
                    {
                        scriptCurrentHighScore.players[j] = scriptCurrentHighScore.players[j - 1];
                        scriptCurrentHighScore.scores[j] = scriptCurrentHighScore.scores[j - 1];
                        scriptCurrentHighScore.times[j] = scriptCurrentHighScore.times[j - 1];
                    }
                    scriptCurrentHighScore.players[i] = scriptMyScore.name;
                    scriptCurrentHighScore.scores[i] = scriptMyScore.score;
                    scriptCurrentHighScore.times[i] = scriptMyScore.time;
                    break;
                }
            } else if (scriptMyScore.score > scriptCurrentHighScore.scores[i])
            {
                for (var j = scriptCurrentHighScore.scores.Length - 1; j != i; j--)
                {
                    scriptCurrentHighScore.players[j] = scriptCurrentHighScore.players[j - 1];
                    scriptCurrentHighScore.scores[j] = scriptCurrentHighScore.scores[j - 1];
                    scriptCurrentHighScore.times[j] = scriptCurrentHighScore.times[j - 1];
                }
                scriptCurrentHighScore.players[i] = scriptMyScore.name;
                scriptCurrentHighScore.scores[i] = scriptMyScore.score;
                scriptCurrentHighScore.times[i] = scriptMyScore.time;
                break;
            }
        }

        for (int i = 0; i < TheHighScores.Length; i++)
        {
            TheHighScores[i].text = "Name: " + scriptCurrentHighScore.players[i] + ", " + "Score: " + scriptCurrentHighScore.scores[i] + ", " + "Time: " + scriptCurrentHighScore.times[i].ToString("F1") + " seconds";
        }
    }
}
