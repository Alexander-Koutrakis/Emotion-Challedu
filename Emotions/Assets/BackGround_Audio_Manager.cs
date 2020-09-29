using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Audio_Manager : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioSource mainAudioSource;
    public static BackGround_Audio_Manager Instance;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Instance = this;
    }
    public void StopMusic()
    {
        StopAllCoroutines();
        Debug.Log("Stop music");
        StartCoroutine(FadeSound());
    }
    private IEnumerator FadeSound()
    {
        if (mainAudioSource.volume > 0) {   
            while (audioSource.volume > 0.1f)
            {
             audioSource.volume = Mathf.Lerp(audioSource.volume, 0, Time.deltaTime);
             yield return null;
            }
        }
        audioSource.Stop();
    }

    public void StartMusic()
    {
        StopAllCoroutines();
        //audioSource.volume = mainAudioSource.volume;
        Debug.Log("Start Music");
        audioSource.Play();
        StartCoroutine(FadeInSound());
        
    }

    public void AddBackgroundClip(AudioClip audioClip)
    {
        Debug.Log("Add clip");
      
        audioSource.clip = audioClip;
        audioSource.Stop();
        audioSource.volume = 0;
    }

    private IEnumerator FadeInSound()
    {


        yield return new WaitForSeconds(1);

        while (mainAudioSource.isPlaying)
        {
           // yield return new WaitForSeconds(1);
            yield return null;
        }


        while(audioSource.volume< mainAudioSource.volume*0.9f)
        {
            audioSource.volume = Mathf.Lerp(audioSource.volume, mainAudioSource.volume, Time.deltaTime*0.5f);
            yield return null;
        }

    }
}
