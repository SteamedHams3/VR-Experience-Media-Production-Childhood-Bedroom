using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellNPCDelay : MonoBehaviour
{

    public GameObject ShadowManYell;
    // Start is called before the first frame update
    void Start()
    {
        ShadowManYell.SetActive(false);
        Invoke("SpawnDelay", 40f);
    }

    void SpawnDelay()
    {
        ShadowManYell.SetActive(true);
        Invoke("HideCharacter", 7f);
    }

    void HideCharacter()
    {
        ShadowManYell.SetActive(false);

    }
}
