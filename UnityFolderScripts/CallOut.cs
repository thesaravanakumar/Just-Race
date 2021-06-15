using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallOut : MonoBehaviour
{
    public AudioSource sound;

    public void OnTriggerEnter2D(Collider2D other)
    {
        sound.Play();
    }
}
