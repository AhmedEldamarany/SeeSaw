using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeeSawFeedback : MonoBehaviour
{
    Image image;
    [SerializeField] Sprite GreenSprite;
    [SerializeField] Sprite RedSprite;
    Sprite defaultSprite;
    void Start()
    {
        image = GetComponent<Image>();
        defaultSprite = image.sprite;
    }

   public void SetColorFeedBack(bool isPositive)
    {
        if (isPositive)
            image.sprite = GreenSprite;
        else 
            image.sprite = RedSprite;

    }
    public void ResetColor()
    {
        image.sprite = defaultSprite;
    }
}
