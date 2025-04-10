using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideNPCDelay : MonoBehaviour
{
       public GameObject ShadowManInside;
       public bool IsActive = false;
  
    public void Start()
    {
        ShadowManInside.SetActive(false);
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
        ShadowManInside.SetActive(false);
    }
    }
}

