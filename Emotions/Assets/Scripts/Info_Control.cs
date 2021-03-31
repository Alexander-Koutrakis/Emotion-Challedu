using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Info_Control : MonoBehaviour
{
    [SerializeField]
    private Sprite engSprite;
    [SerializeField]
    private Sprite itSprite;
    [SerializeField]
    private Sprite romSprite;
    [SerializeField]
    private Sprite grSprite;
    private Image shownImage;

    private void OnEnable()
    {
        shownImage = GetComponent<Image>();
        if (choose_langages.CurrentLang == "en")
        {
            shownImage.sprite = engSprite;
        }
        else if(choose_langages.CurrentLang == "rom")
        {
            shownImage.sprite = romSprite;
        }
        else if (choose_langages.CurrentLang == "it")
        {
            shownImage.sprite = itSprite;
        }
        else if (choose_langages.CurrentLang == "gr")
        {
            shownImage.sprite = grSprite;
        }
    }
}
