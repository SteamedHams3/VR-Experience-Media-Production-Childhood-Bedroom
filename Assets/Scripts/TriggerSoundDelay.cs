using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundDelay : MonoBehaviour
{
    AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        Invoke ("triggerSound", 10f);
    }

    void triggerSound()
    {
       sound.Play();
    }


}
