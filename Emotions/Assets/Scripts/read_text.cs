using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class read_text : MonoBehaviour
{
    public GameObject[] textes;
    public GameObject test;
    public static read_text Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    public void read(string fileName, string[]langage)
    {

        //test.GetComponent<Text>().text = Application.dataPath;
        int i =0 ;

        foreach (GameObject texte in textes)
        {


            string line = langage[i];
            texte.GetComponent<Text>().text = line;

            if (line == null)
            {
                Debug.Log("empty line");
                break;
            }
            
            i++;
        }
        
    }


    
}
