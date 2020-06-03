using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText : MonoBehaviour
{
    public GameObject[] texts;

    // Update is called once per frame
   public void hideText()
    {
        foreach(GameObject text in texts)
        {
            text.SetActive(false);
        }
    }

    public void showText()
    {
        foreach (GameObject text in texts)
        {
            text.SetActive(true);
        }
    }
}
