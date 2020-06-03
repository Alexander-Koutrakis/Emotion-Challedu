using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class next_color : MonoBehaviour
{
    public GameObject[] previous_obj;
    public GameObject[] next_obj;

    public void on_click()
    {
        var colors = GetComponent<Image>().color;
        foreach (GameObject obj in previous_obj)
        {
            colors = new Color32(147, 147, 147, 255);
            obj.GetComponent<Image>().color = colors;
        }
        foreach (GameObject obj in next_obj)
        {
            colors = new Color32(252, 101, 32, 255);
            obj.GetComponent<Image>().color = colors;
        }
    }


}
