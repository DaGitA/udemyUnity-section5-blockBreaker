using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HamburgerMenu : MonoBehaviour
{
    public Sprite pressedSprite;
    private Image myImage;

    public void Awake()
    {
        this.myImage = GetComponent<Image>();
    }

    public void OnClick()
    {
        myImage.sprite = pressedSprite;
    }
}
