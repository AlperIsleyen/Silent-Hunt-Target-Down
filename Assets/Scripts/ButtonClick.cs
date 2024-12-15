using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonImageChanger : MonoBehaviour
{
    public Image button;
    public Sprite normal;
    public Sprite pressed;


    public void OnButtonPress()
    {
        button.sprite = pressed;
    }

    public void OnButtonRelease()
    {
        button.sprite = normal;
    }
}
