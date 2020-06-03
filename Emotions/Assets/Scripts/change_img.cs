using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_img : MonoBehaviour
{
    public GameObject[] emotion1;
    public GameObject[] emotion2;
    public Sprite[] select;
    public Sprite[] select2;

    // Update is called once per frame
    public void on_click()
    {
        int i = 0;
        foreach(GameObject emotion in emotion1)
        {
            emotion.GetComponent<SpriteRenderer>().sprite = select2[i];
            i++;
        }
        i = 0;
        foreach (GameObject emotion in emotion2)
        {
            emotion.GetComponent<SpriteRenderer>().sprite = select[i];
            i++;
        }
    }
}
