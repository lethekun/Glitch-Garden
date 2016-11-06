using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
    private float fadeInTime = 2;
    private float alpha;
    private Image image;
    private Color currentColor;// = Color.black;
    void Start()
    {
        image = GetComponent<Image>();
        currentColor = image.color;
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad < fadeInTime)
        {
            currentColor.a -= Time.deltaTime/2;
            image.color = currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
