using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip HoverFx;
    public AudioClip ClickFx;

    public void HoverSound()
    {
        myFx.PlayOneShot(HoverFx);
    }

    public void ClickSound()
    {
        myFx.PlayOneShot(ClickFx);
    }

}
