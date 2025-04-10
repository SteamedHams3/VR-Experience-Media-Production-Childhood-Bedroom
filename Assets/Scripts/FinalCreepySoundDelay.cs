using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCreepySoundDelay : MonoBehaviour
{
   AudioSource soundInsideFinal;

    void Start()
    {
        soundInsideFinal = GetComponent<AudioSource>();
        Invoke ("triggerSoundFinal", 90f);
    }

    void triggerSoundFinal()
    {
       soundInsideFinal.Play();
    }


}
