﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public AudioClip musicClip;
    public AudioSource audioData;



    // Use this for initialization
    void Start()
    {
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");
        }
    }
}