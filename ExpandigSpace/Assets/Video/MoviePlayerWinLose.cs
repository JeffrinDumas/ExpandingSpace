using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class MoviePlayerWinLose : MonoBehaviour {

    public GameObject open;
    public GameObject close;

    public MovieTexture movie;
    private AudioSource audio;

	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
	}

    void Update()
    {
        if(movie.isPlaying == false)
        {
            open.SetActive(true);
            close.SetActive(false);
        }
    }
}
