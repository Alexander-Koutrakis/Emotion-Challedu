using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_panel : MonoBehaviour
{
    public GameObject panel;
    public GameObject[] tab_emoji;

    public void c_panel()
    {
        
        if (panel != null)
        {
            panel.SetActive(false);
        }
        
        foreach (GameObject emoji in tab_emoji)
        {
            
            emoji.SetActive(true);
        }        
    }
}
