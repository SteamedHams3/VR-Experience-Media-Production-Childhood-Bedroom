using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeSoundDelay : MonoBehaviour
{
   
   AudioSource wardrobeSound;

    void Start()
    {
        wardrobeSound = GetComponent<AudioSource>();
        Invoke ("triggerWardrobeSound", 90f);
    }

    void triggerWardrobeSound()
    {
       wardrobeSound.Play();
    }


}
