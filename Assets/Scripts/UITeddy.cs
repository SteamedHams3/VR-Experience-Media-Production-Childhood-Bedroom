using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITeddy : MonoBehaviour
   {
   public GameObject CanvasTeddy;
   public bool TeddyActive = false;

    public void Start()
    {
       CanvasTeddy.SetActive(false);
       Invoke("LoadDelay", 66f);
    }

    public void LoadDelay()
    {
        CanvasTeddy.SetActive(true);
        Invoke("HideUI", 4f);
    }

    public void HideUI()
    {
        CanvasTeddy.SetActive(false);
    }
}

