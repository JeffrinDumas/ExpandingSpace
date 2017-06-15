using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscoreslist : MonoBehaviour
{
    public string[] players;
    public int[] scores;
    public float[] times;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}