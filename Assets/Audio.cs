using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audio;
    public void playButtonSound()
    {
        audio.Play();
    }
}
