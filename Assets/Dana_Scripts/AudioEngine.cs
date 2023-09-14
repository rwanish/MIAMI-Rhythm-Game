using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioEngine : MonoBehaviour
{
    public static AudioEngine instance = null;

    public AudioSource musicStream;
    public AudioSource soundStream;
    public int bpm = 70;
    public int signature = 4;

    public float timeMusic = 0f;
    float nextBPMTimeCode = 0f;

    // 2 variables pour la d�tection d'un temps fort et d'un temps faible
    public UnityEvent weakTempoEvent;
    public UnityEvent strongTempoEvent;

    public int nbBPM = 0;
    public M1Rotation M1;
    public M2Rotation M2;


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
        timeMusic = musicStream.time;

        // Strong tempo
         if ( nbBPM % signature == 0) 
        {
            strongTempoEvent.Invoke();
            M2.M2Wheel();

        }

        // Weak tempo 
        if (timeMusic > nextBPMTimeCode) 
        {
            weakTempoEvent.Invoke();
            nextBPMTimeCode = nextBPMTimeCode + 60f / bpm;
            nbBPM++;

            M1.M1Wheel();


        }
    }
}
