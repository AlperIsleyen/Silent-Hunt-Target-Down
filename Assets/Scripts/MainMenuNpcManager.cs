using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuNpcManager : MonoBehaviour
{
    public GameObject npcPrefab;
    public int numberOfNPCs = 5;


    private void Awake()
    {

        GameObject[] spawnPointObjects = GameObject.FindGameObjectsWithTag("waypoint");

        List<Transform> spawnPoints = new List<Transform>();
        foreach (GameObject spawnPointObject in spawnPointObjects)
        {
            spawnPoints.Add(spawnPointObject.transform);
        }

        SpawnNPCs(spawnPoints);

    }

    void SpawnNPCs(List<Transform> spawnPoints)
    {

         for (int i = 0; i < numberOfNPCs; i++)
         {

             int Index = Random.Range(0, spawnPoints.Count);
             Transform spawnPoint = spawnPoints[Index];
             GameObject npc = Instantiate(npcPrefab, spawnPoint.position, spawnPoint.rotation);


         }
    }
}
