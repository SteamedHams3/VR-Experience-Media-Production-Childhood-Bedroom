using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideTriggerSound : MonoBehaviour
{
   AudioSource soundInside;

    void Start()
    {
        soundInside = GetComponent<AudioSource>();
        Invoke ("triggerSound", 20f);
    }

    void triggerSound()
    {
       soundInside.Play();
    }


}

