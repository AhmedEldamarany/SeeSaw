using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapper : MonoBehaviour
{
    Image image;
   [SerializeField] Sprite sprite1;
   [SerializeField] Sprite sprite2;
    [SerializeField] bool isFirst = true;
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void SwapSprites()
    {
        if (isFirst)
        {
            image.sprite = sprite2;
            isFirst = false;
        }
        else
        {
            image.sprite = sprite1;
            isFirst = true;
        }
    }
}
