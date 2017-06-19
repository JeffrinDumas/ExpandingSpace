using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class MoviePlayerIntro : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource audio;

    void Start()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
    }

    void Update()
    {
        if (movie.isPlaying == false)
        {
            SceneManager.LoadScene(2);
        }
    }
}
