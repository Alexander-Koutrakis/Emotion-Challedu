using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose_langages : MonoBehaviour
{

    public string langage;
    public GameObject reader;
    public static string CurrentLang="gr";
    


    public void on_click()
    {
        if (langage == "en")
        {
            reader.GetComponent<read_text>().read(langage, reader.GetComponent<save_var>().eng);
            CurrentLang = "en";
        }
        if (langage == "gr")
        {
            reader.GetComponent<read_text>().read(langage, reader.GetComponent<save_var>().gre);
            CurrentLang = "gr";
        }
        if (langage == "rom")
        {
            reader.GetComponent<read_text>().read(langage, reader.GetComponent<save_var>().rom);
            CurrentLang = "rom";
        }
        if (langage == "it")
        {
            reader.GetComponent<read_text>().read(langage, reader.GetComponent<save_var>().italian);
            CurrentLang = "it";
        }

    }
}
