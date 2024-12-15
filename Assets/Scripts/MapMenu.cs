using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject difficultyMenu;

    public void OnReturnButton()
    {
        difficultyMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void OnEasyButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnMediumButton()
    {
        SceneManager.LoadScene(2);
    }
    public void OnHardButton()
    {
        SceneManager.LoadScene(3);
    }
}
