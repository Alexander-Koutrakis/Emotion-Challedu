using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLanguage : MonoBehaviour
{
    private void Awake()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            choose_langages.CurrentLang = "en";
            read_text.Instance.read(choose_langages.CurrentLang, save_var.Instance.eng);
        }else if (Application.systemLanguage == SystemLanguage.Romanian)
        {
            choose_langages.CurrentLang = "rom";
            read_text.Instance.read(choose_langages.CurrentLang, save_var.Instance.rom);
        }
        else if (Application.systemLanguage == SystemLanguage.Italian)
        {
            choose_langages.CurrentLang = "it";
            read_text.Instance.read(choose_langages.CurrentLang, save_var.Instance.italian2);
        }
        else if (Application.systemLanguage == SystemLanguage.Greek)
        {
            choose_langages.CurrentLang = "gr";
            read_text.Instance.read(choose_langages.CurrentLang, save_var.Instance.gre);
        }

        Debug.Log(choose_langages.CurrentLang);
    }
}
