using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyDespawnSoundEffectDelay : MonoBehaviour
   {
    AudioSource CreepyDespawn;

    void Start()
    {
        CreepyDespawn = GetComponent<AudioSource>();
        Invoke ("triggerCreepyDespawn", 36f);
        //Invoke ("triggerCreepyDespawn", 72f);
        Invoke ("triggerCreepyDespawn", 96f);
    }

    void triggerCreepyDespawn()
    {
       CreepyDespawn.Play();
    }
}

