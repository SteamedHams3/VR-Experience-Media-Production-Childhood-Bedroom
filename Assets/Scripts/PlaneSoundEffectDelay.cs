using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSoundEffectDelay : MonoBehaviour
{
    AudioSource PlaneSoundEffect;

    void Start()
    {
        PlaneSoundEffect = GetComponent<AudioSource>();
        Invoke ("triggerPlaneSoundEffect", 22.5f);
    }

    void triggerPlaneSoundEffect()
    {
       PlaneSoundEffect.Play();
    }


}