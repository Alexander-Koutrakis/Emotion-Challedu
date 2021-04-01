using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeOut : MonoBehaviour
{
    private Image image;
    private Color newColor;

    void Start()
    {
        image = GetComponentInChildren<Image>();
        StartCoroutine(WaitTofade());
    }

    private IEnumerator WaitTofade()
    {
        yield return new WaitForSeconds(2);
        while (image.color.a > 0)
        {
            float newAlpha = image.color.a - Time.deltaTime / 1;
            newColor = new Color(image.color.r, image.color.g, image.color.b, newAlpha);
            image.color = newColor;
            yield return null;
        }

        Destroy(gameObject);
    }
}
