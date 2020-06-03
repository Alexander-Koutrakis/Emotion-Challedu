using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaytextSound : MonoBehaviour
{
    public AudioClip audioclipEN;
    public AudioClip audioclipGR;
    public AudioClip audioclipROM;
    public AudioClip audioclipIT;
    public AudioClip audioclip;
    public AudioSource audioSrc;
    public float delay = 1f;
    IEnumerator co;

    private void Awake()
    {
        co = PlaytextSoundDelay();
    }

    private void OnEnable()
    {
        SelectClip(choose_langages.CurrentLang);
        co = PlaytextSoundDelay();
        StartCoroutine(co);

    }

    private void OnDisable()
    {

        StopCoroutine(co);
        audioSrc.Stop();
    }


    IEnumerator PlaytextSoundDelay()
    {

        yield return new WaitForSeconds(delay);
        audioSrc.clip = audioclip;
        if(audioSrc.clip!=null)
        audioSrc.Play();
    }


    private void SelectClip(string lang)
    {
        if (choose_langages.CurrentLang == "en")
        {
            audioclip = audioclipEN;
        }
        else if (choose_langages.CurrentLang == "gr")
        {
            audioclip = audioclipGR;
        }
        else if (choose_langages.CurrentLang == "rom")
        {
            audioclip = audioclipROM;
        }
        else if (choose_langages.CurrentLang == "it")
        {
            audioclip = audioclipIT;
        }
    }

    private void Test()
    {
        StartCoroutine(co);
    }
}
