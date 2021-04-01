﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clique : MonoBehaviour
{
    public bool isclick = false;
    public int id;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public GameObject emoji;
    
    public AudioSource audioSrc;
    [SerializeField]
    private AudioClip[] greekSounds;
    [SerializeField]
    private AudioClip[] engSounds;
    [SerializeField]
    private AudioClip[] itSounds;
    [SerializeField]
    private AudioClip[] romSounds;
    private Dictionary<string, AudioClip[]> audios = new Dictionary<string, AudioClip[]>();


    public GameObject[] previous_obj;
    public GameObject[] next_obj;

    private void Awake()
    {
        audios.Add("gr", greekSounds);
        audios.Add("en", engSounds);
        audios.Add("rom", romSounds);
        audios.Add("it", itSounds);
        Debug.Log(audios["en"].Length);
    }
    public void on_click()
    {
        foreach(GameObject obj in previous_obj)
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in next_obj)
        {
            obj.SetActive(true);
        }
    }

    private void OnEnable()
    {
        PlayRandom();
    }


    void Update()
    {
        if (isclick == true)
        {
            on_click();
        }
    }

    void OnMouseDown()
    {
        isclick = true;
               
    }

    private AudioClip RandomClip(string language)
    {
        Debug.Log(language);
        int x = Random.Range(0, audios[language].Length);
        Debug.Log(audios[language].Length);
        Debug.Log(x);
        return audios[language][x];
    }
    public void PlayRandom()
    {

        audioSrc.PlayOneShot(RandomClip(choose_langages.CurrentLang));
        isclick = false;
    }


    public void PlayRandomSound()
    {
        Debug.Log(choose_langages.CurrentLang);
        if (choose_langages.CurrentLang == "gr" || choose_langages.CurrentLang == "en")
        {
            AudioClip[] soundArray = { sound1, sound2, sound3, sound4, sound5, sound6 };
            int rand = Random.Range(0, soundArray.Length);
            if (audioSrc.clip != null)
            {
                    audioSrc.PlayOneShot(soundArray[rand]);
            }
            isclick = false;
        }
        else {
            audioSrc.PlayOneShot(sound6);

            isclick = false;
        }
    }


    void OnMouseUp()
    {
        isclick = false;
    }
}
