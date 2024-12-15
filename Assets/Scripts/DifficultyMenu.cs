using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject difficultyMenu;

    public void OnReturnButton()
    {
        difficultyMenu.SetActive(false);
    }
    public void OnEasyButton()
    {
        SetDifficulty(0);
        SetNumberOfNpc(30);
        SetBullet(5);
        mainMenu.SetActive(true);
        difficultyMenu.SetActive(false);
    }
    public void OnMediumButton()
    {
        SetDifficulty(1);
        SetBullet(4);
        SetNumberOfNpc(40);
        mainMenu.SetActive(true);
        difficultyMenu.SetActive(false);
    }
    public void OnHardButton()
    {
        SetDifficulty(2);
        SetNumberOfNpc(50);
        SetBullet(3);
        mainMenu.SetActive(true);
        difficultyMenu.SetActive(false);
    }
    void SetDifficulty(int int_difficulty)
    {
        GameManager.Instance.SetDifficulty(int_difficulty);
    }

    void SetNumberOfNpc(int int_npcCount)
    {
        GameManager.Instance.SetNumberOfNpc(int_npcCount);
    }
    void SetBullet(int int_bullet)
    {
        GameManager.Instance.SetBullet(int_bullet);
    }
}
