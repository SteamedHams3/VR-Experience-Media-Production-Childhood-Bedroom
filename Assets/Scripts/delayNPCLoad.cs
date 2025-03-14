using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayNPCLoad : MonoBehaviour
{
    public GameObject ShadowMan;
    // Start is called before the first frame update
    void Start()
    {
        ShadowMan.SetActive(false);
        Invoke("SpawnDelay", 11f);
    }

    void SpawnDelay()
    {
        ShadowMan.SetActive(true);
        Invoke("HideCharacter", 7f);
    }

    void HideCharacter()
    {
        ShadowMan.SetActive(false);

    }


   
}
