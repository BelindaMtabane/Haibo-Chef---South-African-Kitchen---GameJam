using System;
using UnityEngine;
using TMPro;

using System.Collections.Generic;

public class Music : MonoBehaviour
{
    //Create Variables
    public AudioSource audioBCKGND;
    public AudioClip ambienceClip;

    void Start()
    {
        if (audioBCKGND != null && ambienceClip != null)
        {
            audioBCKGND.clip = ambienceClip;
            audioBCKGND.loop = true;
            audioBCKGND.Play();

        }
    }
}
