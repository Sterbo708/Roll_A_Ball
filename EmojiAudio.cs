using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiAudio : MonoBehaviour
{

    public AudioClip emoji_1;
    public AudioClip emoji_2;
    public AudioClip emoji_3;
    public AudioClip emoji_4;
    public AudioSource source;


    // Use this for initialization
    void Update()
    {
        source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Powerup_1"))
        {
            source.PlayOneShot(emoji_1);
        }
        else if (gameObject.CompareTag("Powerup_2"))
        {
            source.PlayOneShot(emoji_2);
        }
        else if (gameObject.CompareTag("Powerup_3"))
        {
            source.PlayOneShot(emoji_3);
        }
        else if (gameObject.CompareTag("Powerup_4"))
        {
            source.PlayOneShot(emoji_4);
        }
    }
}

	