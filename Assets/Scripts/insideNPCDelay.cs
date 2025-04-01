using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideNPCDelay : MonoBehaviour
{
       public GameObject ShadowManInside;
  
    public void Start()
    {
        ShadowManInside.SetActive(false);
        Invoke("SpawnDelay", 20f);
    }

   public void SpawnDelay()
    {
        ShadowManInside.SetActive(true);
        Invoke("HideCharacter", 12f);
    }

    public void HideCharacter()
    {
        ShadowManInside.SetActive(false);
    }
}

