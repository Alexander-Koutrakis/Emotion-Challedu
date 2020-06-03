using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    public GameObject[] previous_obj;
    public GameObject[] next_obj;

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

  

}
