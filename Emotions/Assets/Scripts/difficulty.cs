using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;

    public GameObject item4;
    public GameObject item5;
    public GameObject item6;

    public GameObject item7;
    public int int_dificulty;
    public bool bool_dificulty;

    public GameObject cam;

    void Start()
    {

    }

    // Update is called once per frame
    public void on_click()
    {
        int actual_diff = cam.GetComponent<save_var>().difficulty;

        if(actual_diff != int_dificulty)
        {
            Vector2 pos = item1.GetComponent<Transform>().localPosition;
            pos.x = pos.x + 220 * int_dificulty;
            item1.GetComponent<Transform>().localPosition = pos;

            pos = item2.GetComponent<Transform>().localPosition;
            pos.x = pos.x - 220 * int_dificulty;
            item2.GetComponent<Transform>().localPosition = pos;

            item3.SetActive(bool_dificulty);

            pos = item4.GetComponent<Transform>().localPosition;
            pos.x = pos.x + 220 * int_dificulty;
            item4.GetComponent<Transform>().localPosition = pos;

            pos = item5.GetComponent<Transform>().localPosition;
            pos.x = pos.x - 220 * int_dificulty;
            item5.GetComponent<Transform>().localPosition = pos;

            pos = item7.GetComponent<Transform>().localPosition;
            pos.x = pos.x + 220 * int_dificulty;
            item7.GetComponent<Transform>().localPosition = pos;

            item6.SetActive(bool_dificulty);

            cam.GetComponent<save_var>().difficulty = cam.GetComponent<save_var>().difficulty * -1;
        }

        
    }
}
