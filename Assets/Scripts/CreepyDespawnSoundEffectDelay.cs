using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyDespawnSoundEffectDelay : MonoBehaviour
   {
    AudioSource CreepyDespawn;

    void Start()
    {
        CreepyDespawn = GetComponent<AudioSource>();
        Invoke ("triggerCreepyDespawn", 37f);
        Invoke ("triggerCreepyDespawn", 72f);
        Invoke ("triggerCreepyDespawn", 97f);
    }

    void triggerCreepyDespawn()
    {
       CreepyDespawn.Play();
    }
}

