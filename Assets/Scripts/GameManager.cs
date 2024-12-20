using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public int difficulty;
    public int numberOfNpc;
    public int bullet;
    public GameObject targetKilledUI;
    public GameObject innocentKilledUI;
    public GameObject outOfAmmoUI;
    public GameObject outOfTimeUI;

    public static GameManager Instance;

    public AudioSource source;

    public AudioClip win;
    public AudioClip lose;
    public AudioClip ammo;
    public AudioClip time;
    private void Awake()
    {
 
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    public void SetDifficulty(int int_difficulty)
    {
        difficulty = int_difficulty;
    }

    public void SetNumberOfNpc(int int_npcCount)
    {
        numberOfNpc = int_npcCount;
    }
    public void SetBullet(int int_bullet)
    {
        bullet = int_bullet;

    }
    public void TargetKilled()
    {
        GameObject pistol = GameObject.FindWithTag("Pistol");
        Weapon weapon = pistol.GetComponent<Weapon>();
        weapon.enabled = false;
        source.clip = win;
        source.Play();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        targetKilledUI = GameObject.FindWithTag("TargetKilledUI");
        GameObject targetKilledUII = targetKilledUI.transform.GetChild(0).gameObject;
        targetKilledUII.SetActive(true);
    }
    public void InnocentKilled()
    {
        GameObject pistol = GameObject.FindWithTag("Pistol");
        Weapon weapon = pistol.GetComponent<Weapon>();
        weapon.enabled = false;
        source.clip = lose;
        source.Play();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        innocentKilledUI = GameObject.FindWithTag("InnocentKilledUI");
        GameObject innocentKilledUII = innocentKilledUI.transform.GetChild(0).gameObject;
        innocentKilledUII.SetActive(true);
    }
    public void OutOfAmmo()
    {
        GameObject pistol = GameObject.FindWithTag("Pistol");
        Weapon weapon = pistol.GetComponent<Weapon>();
        weapon.enabled = false;
        source.clip = ammo;
        source.Play();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        outOfAmmoUI = GameObject.FindWithTag("OutOfAmmoUI");
        GameObject outOfAmmoUII = outOfAmmoUI.transform.GetChild(0).gameObject;
        outOfAmmoUII.SetActive(true);
    }
    public void OutOfTime()
    {
        GameObject pistol = GameObject.FindWithTag("Pistol");
        Weapon weapon = pistol.GetComponent<Weapon>();
        weapon.enabled = false;
        source.clip = time;
        source.Play();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        outOfTimeUI = GameObject.FindWithTag("OutOfTimeUI");
        GameObject outOfTimeUII = outOfTimeUI.transform.GetChild(0).gameObject;
        outOfTimeUII.SetActive(true);
    }


}