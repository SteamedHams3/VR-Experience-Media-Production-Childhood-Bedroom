using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutroSoundEffectDelay : MonoBehaviour
{
    AudioSource OutroSound;

    void Start()
    {
        OutroSound = GetComponent<AudioSource>();
        Invoke ("triggerOutroSound", 105f);
    }

    void triggerOutroSound()
    {
       OutroSound.Play();
    }


}
