using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    private AudioSource audioSrc;
    public GameObject audiogo;
    public float volume;
    void Start()
    {
        audioSrc = audiogo.GetComponent<AudioSource>();
    }

    public void on_click()
    {
        audioSrc.volume = volume;
    }
}
