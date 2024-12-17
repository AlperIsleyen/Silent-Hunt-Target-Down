using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int difficulty;
    public int numberOfNpc;
    public int bullet;
    public GameObject targetKilledUI;
    public GameObject innocentKilledUI;
    public GameObject outOfAmmoUI;

    public static GameManager Instance;

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
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        targetKilledUI = GameObject.FindWithTag("TargetKilledUI");
        GameObject targetKilledUII = targetKilledUI.transform.GetChild(0).gameObject;
        targetKilledUII.SetActive(true);
    }
    public void InnocentKilled()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        innocentKilledUI = GameObject.FindWithTag("InnocentKilledUI");
        GameObject innocentKilledUII = innocentKilledUI.transform.GetChild(0).gameObject;
        innocentKilledUII.SetActive(true);
    }
    public void OutOfAmmo()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        outOfAmmoUI = GameObject.FindWithTag("OutOfAmmoUI");
        GameObject outOfAmmoUII = outOfAmmoUI.transform.GetChild(0).gameObject;
        outOfAmmoUII.SetActive(true);
    }
}
