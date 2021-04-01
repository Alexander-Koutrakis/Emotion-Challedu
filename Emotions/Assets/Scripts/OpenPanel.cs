using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject NextPanel;
    [SerializeField]
    private GameObject NextQuestion;
    [SerializeField]
    private GameObject CurrentPanel;
    private void OnMouseDown()
    {
        CurrentPanel.SetActive(false);
        NextPanel.SetActive(true);
        NextQuestion.SetActive(true);
    }
}
