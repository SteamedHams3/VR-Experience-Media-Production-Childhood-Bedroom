using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightLampController : MonoBehaviour
{
    public void lampClicked()
    {
        Debug.Log("lamp clicked");
    }

    public void ToggleLight()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
