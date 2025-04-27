using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideNPCDelay : MonoBehaviour
{
       public GameObject ShadowManInside;
       public GameObject CreepyDespawnSoundEffect;
       public bool IsActive = false;
       AudioSource CreepyDespawn;
  
    public void Start()
    {
        ShadowManInside.SetActive(false);
        CreepyDespawn = CreepyDespawnSoundEffect.GetComponent<AudioSource>();
        Invoke("SpawnDelay", 60f);
        Invoke ("SetIsActive", 63f);
    }

   public void SpawnDelay()
    {
        ShadowManInside.SetActive(true);
        Invoke("HideCharacter", 12f);
    }

    public void SetIsActive()
    {
       IsActive = true;
    }

    public void HideCharacter()
    {
        if(IsActive)
        {
        CreepyDespawn.Play();
        ShadowManInside.SetActive(false);
    }
    }
}

