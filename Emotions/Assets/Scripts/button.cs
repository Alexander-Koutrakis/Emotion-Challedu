using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject panel;
    public int last_emo;
    public GameObject[] tab_emoji;

    public void open_panel()
    {
        print(last_emo);
        if(panel != null)
        {
            panel.SetActive(true);
        }

        foreach (GameObject emoji in tab_emoji)
        {
            emoji.SetActive(false);
        }


    }
}
