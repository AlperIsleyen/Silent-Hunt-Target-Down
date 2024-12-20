using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject difficultyMenu;

    public void OnPlayButton()
    {
        difficultyMenu.SetActive(true);
    }

}

