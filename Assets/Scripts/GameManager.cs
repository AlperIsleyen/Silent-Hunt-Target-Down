using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int difficulty;
    public int numberOfNpc;
    public int bullet;

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
        Debug.Log("Difficulty set to: " + difficulty);
    }

    public void SetNumberOfNpc(int int_npcCount)
    {
        numberOfNpc = int_npcCount;
        Debug.Log("Number of NPCs set to: " + numberOfNpc);
    }
    public void SetBullet(int int_bullet)
    {
        bullet = int_bullet;

    }
}
