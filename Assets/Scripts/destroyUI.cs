using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyUI : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {
        DestroyUI(Canvas);
    }

    public void DestroyUI(GameObject Canvas)
    {
        Destroy(Canvas, 4);
    }
}
