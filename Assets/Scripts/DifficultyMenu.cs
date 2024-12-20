using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject difficultyMenu;
    public AudioSource source;

    public AudioClip returnSound;
    public AudioClip easySound;
    public AudioClip mediumSound;
    public AudioClip hardSound;

    public void OnReturnButton()
    {
        source.clip = returnSound;
        source.Play();
        difficultyMenu.SetActive(false);
    }
    public void OnEasyButton()
    {
        source.clip = easySound;
        source.Play();
        SetDifficulty(0);
        SetNumberOfNpc(30);
        SetBullet(5);
        mainMenu.SetActive(true);
        difficultyMenu.SetActive(false);
    }
    public void OnMediumButton()
    {
        source.clip = mediumSound;
        source.Play();
        SetDifficulty(1);
        SetBullet(4);
        SetNumberOfNpc(40);
        mainMenu.SetActive(true);
        difficultyMenu.SetActive(false);
    }
    public void OnHardButton()
    {
        source.clip = hardSound;
        source.Play();
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