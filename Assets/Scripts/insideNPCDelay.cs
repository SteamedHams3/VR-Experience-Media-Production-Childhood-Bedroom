using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideNPCDelay : MonoBehaviour
{
       public GameObject ShadowManInside;
  
    void Start()
    {
        ShadowManInside.SetActive(false);
        Invoke("SpawnDelay", 20f);
    }

    void SpawnDelay()
    {
        ShadowManInside.SetActive(true);
        Invoke("HideCharacter", 8f);
    }

    void HideCharacter()
    {
        ShadowManInside.SetActive(false);

    }


   
}

