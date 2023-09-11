using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioEngine : MonoBehaviour
{
    public static AudioEngine instance = null;

    public AudioSource musicStream;
    public AudioSource soundStream;
    public int bpm;
    public int signature;

    // 2 variables pour la détection d'un temps fort et d'un temps faible
    public UnityEvent weakTempoEvent;
    public UnityEvent strongTempoEvent;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void PlaySound(AudioClip soundClipToPlay)
    {
        soundStream.clip = soundClipToPlay;
        soundStream.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Strong tempo computation : TO DO !
        if (false) // Change with a real condition : TO DO !
        {
            strongTempoEvent.Invoke();
        }

        // Weak tempo computation : TO DO !
        if (false) // Change with a real condition : TO DO !
        {
            weakTempoEvent.Invoke();
        }
    }
}
