using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  gives a question when asked
/// </summary>
public class QuestionGiver : MonoBehaviour
{
    public Question[] questions;

    public Question GiveQuestion()
    {
        int randomIndex = Random.Range(0, questions.Length);
        return questions[randomIndex];
    }
}

[System.Serializable]
public class Question
{
    public string questionText;
    public Answer[] answers;
}


[System.Serializable]
public class Answer
{
    public string answerText;
    public bool correct;
}
