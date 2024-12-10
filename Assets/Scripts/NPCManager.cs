using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class NPCManager : MonoBehaviour
{
    public GameObject npcPrefab;
    public int numberOfNPCs = 20;
    public int guilty = 0;

    GameObject target;

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
    void Start()
    {

        FindClothing();
        
    }

    void SpawnNPCs(List<Transform> spawnPoints)
    {

        for (int i = 0; i < numberOfNPCs; i++)
        {
       
            int Index = Random.Range(0, spawnPoints.Count);
            Transform spawnPoint = spawnPoints[Index];
            GameObject npc = Instantiate(npcPrefab, spawnPoint.position, spawnPoint.rotation);

            if (i == guilty)
            {
                npc.tag = "Target";
                npc.name = "Target";
            }

        }
    }
    void FindClothing()
    {
        StartCoroutine(wait());
        IEnumerator wait()
        {
            yield return new WaitForSeconds(0.1f);
            
            target = GameObject.FindGameObjectWithTag("Target");
            int suit = target.GetComponent<clothing>().suit;
            int skin = target.GetComponent<clothing>().skin;
            int hair = target.GetComponent<clothing>().hair;
            string Suit = "";
            string Skin = "";
            string Hair = "";
            string Trouser = "";
            string Short = "";
            string Shoes = "";
            // bankersuit    0
            // cocksuit      1
            // farmersuit    2
            // firemansuit   3
            // mechanicsuit  4
            // nursesuit     5
            // policesuit    6
            // roobersuit    7
            // securitysuit  8
            // sellersuit    9
            // workersuit    10
            if (bool_suit = true)
            {
            if (suit == 0)
            {
                Suit = "Banker";
            }
            else if (suit == 1)
            {
                Suit = "Cocksuit";
            }
            else if (suit == 2)
            {
                Suit = "Farmersuit";
            }
            else if (suit == 3)
            {
                Suit = "Firemansuit";
            }
            else if (suit == 4)
            {
                Suit = "Mechanicsuit";
            }
            else if (suit == 5 )
            {
                Suit = "Nursesuit";
            }
            else if (suit == 6)
            {
                Suit = "Policesuit";
            }
            else if (suit == 7)
            {
                Suit = "Roobersuit";
            }
            else if (suit == 8)
            {
                Suit = "Securitysuit";
            }
            else if (suit == 9)
            {
                Suit = "Sellersuit";
            }
            else if (suit == 10)
            {
                Suit = "Workersuit";
            } 
            }
            else
            {
              if (bool_trouser == 1)  
              {
                 if (int_trouser == 0)
                 {
                    Trouser = "Blue Jeans";
                 }
                 else if (int_trouser == 1)
                 {
                    Trouser = "Cream Trousers";
                 }
                 else if (int_trouser == 2)
                 {
                    Trouser = "Black Trousers with White Stripes";
                 }
                 else if (int_trouser == 3)
                 {
                    Trouser = "Black Trousers with Cream Stripes";
                 }
                 else if (int_trouser == 4)
                 {
                    Trouser = "Light Cream Trousers";
                 }
                 else if (int_trouser == 5)
                 {
                    Trouser = "Red Trousers";
                 }
                 else if (int_trouser == 6)
                 {
                    Trouser = "Blue Trousers";
                 }
                 else if (int_trouser == 7)
                 {
                    Trouser = "Pink Trousers";
                 }
                 else if (int_trouser == 8)
                 {
                    Trouser = "Gray Trousers";
                 }
                 else if (int_trouser == 9)
                 {
                    Trouser = "Green Trousers";
                 }
                 else if (int_trouser == 10)
                 {
                    Trouser = "Light Gray Trousers";
                 }
                 else if (int_trouser == 11)
                 {
                    Trouser = "White Trousers"
                 }
                 else if (int_trouser == 12)
                 {
                    Trouser = "Brown Trousers";
                 }
                 else if (int_trouser == 13)
                 {
                    Trouser = "Light Blue Trousers";
                 }
                 else if (int_trouser == 14)
                 {
                    Trouser = "Dark Green Trousers";
                 }
              }
            }
                else if(bool_trouser == 0)
                {
                if (int_short_trouser == 0)
                {
                    Short = "Blue Shorts";
                }
                else if (int_short_trouser ==1)
                {
                    Short = "Gray Shorts";
                }
                else if (int_short_trouser == 2)
                {
                    Short = "Cream Shorts";
                }
                else if (int_short_trouser == 3)
                {
                    Short = "Green Shorts";
                }
                else if (int_short_trouser == 4)
                {
                    Short = "Blue Shorts with Red And White Stripes";
                }
                else if (int_short_trouser == 5)
                {
                    Short = "Dark Blue Shorts";
                }
                else if (int_short_trouser == 6)
                {
                    Short = "Pink Shorts";
                }
                else if (int_short_trouser == 7)
                {
                    Short = "Black Shorts";
                }
                else if (int_short_trouser == 8)
                {
                    Short = "Orange Shorts";
                }
                else if (int_short_trouser == 9)
                {
                    Short = "Gray Shorts with Yellow Stripes";
                }
                else if (int_short_trouser == 10)
                {
                    Short = "Cream White Shorts";
                }
                
                }
               
            
            
            //

            if(skin == 0 || skin == 1)
            {
                Skin = "Dark Skinned";
            }
            else if(skin >= 2)
            {
                Skin = "Light Skinned";
            }
            //

            if(hair == 0)
            {
                Hair = "Dark";
            }
            else if(hair == 1)
            {
                Hair = "Brown";
            }
            else if(hair == 2)
            {
                Hair = "Blonde";
            }
            //
            if(bool_shoe == 1)
            {
                if (shoes == 0)
                {
                if(int_shoe == 0)
                {
                    Shoes = "White Shoes";
                }
                else if(int_shoe == 1)
                {
                    Shoes = "Pink Shoes";
                }
                else if(int_shoe == 2)
                {
                    Shoes = "Gray Shoes";
                }
                else if(int_shoe == 3)
                {
                    Shoes = "Brown Shoes";
                }
                else if(int_shoe == 4)
                {
                    Shoes = "Red Shoes";
                }
                else if(int_shoe == 5)
                {
                    Shoes = "Black Shoes";
                }
                else if(int_shoe == 6)
                {
                    Shoes = "Khaki Shoes";
                }
                else if(int_shoe == 7)
                {
                    Shoes = "Dark Gray Shoes";
                }
                } 
                //






            string Text = "Suit:" + Suit + " \n";
            Text += "Skin Color: " + Skin + "\n ";
            Text += "Hair Color" + Hair + "\n";
            Text += "Trouser: " + Trouser + "\n";
            Text += "Short: " + Short + "\n";
            Debug.Log(Text);


        }

    }
}
    