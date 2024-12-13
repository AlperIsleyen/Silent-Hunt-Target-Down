using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
public class NPCManager : MonoBehaviour
{
    public GameObject npcPrefab;
    public int numberOfNPCs = 20;
    public int guilty = 0;
    public TextMeshPro text;
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
            npc.tag = "Innocent";
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
            string Text = "";
            target = GameObject.FindGameObjectWithTag("Target");
            int suit = target.GetComponent<clothing>().suit;
            int skin = target.GetComponent<clothing>().skin;
            int hair = target.GetComponent<clothing>().hair_color;
            int trouser = target.GetComponent<clothing>().int_trouser;
            int short_trouser = target.GetComponent<clothing>().int_short_trouser;
            int shoe = target.GetComponent<clothing>().int_shoe;
            bool bool_suit = target.GetComponent<clothing>().bool_suit;
            bool bool_trouser = target.GetComponent<clothing>().bool_trouser;
            bool bool_shoe = target.GetComponent<clothing>().bool_shoe;
            int shoe_type = target.GetComponent<clothing>().shoe_type;
            bool glass = target.GetComponent<clothing>().glass;
            bool scraf = target.GetComponent<clothing>().scraf;
            bool chani = target.GetComponent<clothing>().chani;
            int sex = target.GetComponent<clothing>().sex;
            int upper = target.GetComponent<clothing>().int_upper;
            int upper_cloth = target.GetComponent<clothing>().int_upper_cloth;


            string Suit = "";
            string Skin = "";
            string Hair = "";
            string Trouser = "";
            string Short = "";
            string Shoes = "";
            string Glasses = "";
            string Scarf = "";
            string Chain = "";
            string Gender = "";
            string Upper = "";

            if (bool_suit == true)
            {
                if (suit == 0) { Suit = "Banker"; }
                else if (suit == 1) { Suit = "Cocksuit"; }
                else if (suit == 2) { Suit = "Farmersuit"; }
                else if (suit == 3) { Suit = "Firemansuit"; }
                else if (suit == 4) { Suit = "Mechanicsuit"; }
                else if (suit == 5) { Suit = "Nursesuit"; }
                else if (suit == 6) { Suit = "Policesuit"; }
                else if (suit == 7) { Suit = "Robbersuit"; }
                else if (suit == 8) { Suit = "Securitysuit"; }
                else if (suit == 9) { Suit = "Sellersuit"; }
                else if (suit == 10) { Suit = "Workersuit"; }
                Text = "Suit: " + Suit + " \n";
            }
            else
            {
                if (bool_trouser == true)
                {
                    if (trouser == 0) { Trouser = "Blue Jeans"; }
                    else if (trouser == 1) { Trouser = "Cream Trousers"; }
                    else if (trouser == 2) { Trouser = "Black Trousers with White Stripes"; }
                    else if (trouser == 3) { Trouser = "Black Trousers with Cream Stripes"; }
                    else if (trouser == 4) { Trouser = "Light Cream Trousers"; }
                    else if (trouser == 5) { Trouser = "Red Trousers"; }
                    else if (trouser == 6) { Trouser = "Blue Trousers"; }
                    else if (trouser == 7) { Trouser = "Pink Trousers"; }
                    else if (trouser == 8) { Trouser = "Gray Trousers"; }
                    else if (trouser == 9) { Trouser = "Green Trousers"; }
                    else if (trouser == 10) { Trouser = "Light Gray Trousers"; }
                    else if (trouser == 11) { Trouser = "White Trousers"; }
                    else if (trouser == 12) { Trouser = "Brown Trousers"; }
                    else if (trouser == 13) { Trouser = "Light Blue Trousers"; }
                    else if (trouser == 14) { Trouser = "Dark Green Trousers"; }
                    Text += "Trouser: " + Trouser + "\n";
                }
                else if (bool_trouser == false)
                {
                    if (short_trouser == 0) { Short = "Blue Shorts"; }
                    else if (short_trouser == 1) { Short = "Gray Shorts"; }
                    else if (short_trouser == 2) { Short = "Cream Shorts"; }
                    else if (short_trouser == 3) { Short = "Green Shorts"; }
                    else if (short_trouser == 4) { Short = "Blue Shorts with Red And White Stripes"; }
                    else if (short_trouser == 5) { Short = "Dark Blue Shorts"; }
                    else if (short_trouser == 6) { Short = "Pink Shorts"; }
                    else if (short_trouser == 7) { Short = "Black Shorts"; }
                    else if (short_trouser == 8) { Short = "Orange Shorts"; }
                    else if (short_trouser == 9) { Short = "Gray Shorts with Yellow Stripes"; }
                    else if (short_trouser == 10) { Short = "Cream White Shorts"; }
                    Text += "Short: " + Short + "\n";
                }
                if (upper_cloth == 0)
                {
                    if (upper == 0) { Upper = "Brown Pullover"; }
                    else if (upper == 1) { Upper = "Gray Pullover"; }
                    else if (upper == 2) { Upper = "Dark Blue Pullover"; }
                    else if (upper == 3) { Upper = "Dark Blue Pullover with Red and White Stripes"; }
                    else if (upper == 4) { Upper = "Gray Pullover"; }
                    else if (upper == 5) { Upper = "Light Gray Pullover"; }
                    else if (upper == 6) { Upper = "Pink Pullover"; }
                    else if (upper == 7) { Upper = "White Pullover"; }
                    else if (upper == 8) { Upper = "Red Pullover with White Pullover"; }
                    else if (upper == 9) { Upper = "White Pullover with Blue and Green Stripes"; }
                    else if (upper == 10) { Upper = "Black Pullover"; }
                    else if (upper == 11) { Upper = "Red Pullover"; }
                    else if (upper == 12) { Upper = "Gray Pullover with Black Stripes"; }
                    else if (upper == 13) { Upper = "Green Pullover"; }
                    else if (upper == 14) { Upper = "Yellow Pullover"; }
                    else if (upper == 15) { Upper = "Light Gray Pullover"; }
                    else if (upper == 16) { Upper = "Blue Pullover"; }
                    Text += "Upper: " + Upper + "\n";

                }
                else if (upper_cloth == 1)
                {
                    if (upper == 0) { Upper = "Light Blue Shirt"; }
                    else if (upper == 1) { Upper = "Black Shirt"; }
                    else if (upper == 2) { Upper = "Light Gray Shirt"; }
                    else if (upper == 3) { Upper = "Blue Shirt with White Stripes"; }
                    else if (upper == 4) { Upper = "Red Shirt with White Stipes "; }
                    else if (upper == 5) { Upper = "Gray Shirt with White Stripes"; }
                    else if (upper == 6) { Upper = "Pink Shirt"; }
                    else if (upper == 7) { Upper = "Blue Shirt"; }
                    else if (upper == 8) { Upper = "White Shirt"; }
                    else if (upper == 9) { Upper = "Brown Shirt"; }
                    else if (upper == 10) { Upper = "Burgundy Shirt"; }
                    else if (upper == 11) { Upper = "Light Brown Shirt"; }
                    else if (upper == 12) { Upper = "Light Blue Shirt"; }
                    else if (upper == 13) { Upper = "Red Shirt"; }
                    Text += "Upper: " + Upper + "\n";
                }
                else if (upper_cloth == 2)
                {
                    if (upper == 0) { Upper = "White T-Shirt"; }
                    else if (upper == 1) { Upper = "Dark Gray T-Shirt"; }
                    else if (upper == 2) { Upper = "Gray T-Shirt"; }
                    else if (upper == 3) { Upper = "White T-Shirt"; }
                    else if (upper == 4) { Upper = "Green T-Shirt"; }
                    else if (upper == 5) { Upper = "Blue T-Shirt with Boss Design"; }
                    else if (upper == 6) { Upper = "Blue T-Shirt"; }
                    else if (upper == 7) { Upper = "White T-Shirt with Level Design"; }
                    else if (upper == 8) { Upper = "White T-Shirt"; }
                    else if (upper == 9) { Upper = "Black T-Shirt"; }
                    else if (upper == 10) { Upper = "Blue T-Shirt"; }
                    else if (upper == 11) { Upper = "White T-Shirt"; }
                    else if (upper == 12) { Upper = "Yelow T-Shirt"; }
                    else if (upper == 13) { Upper = "Green T-Shirt"; }
                    else if (upper == 14) { Upper = "Red T-Shirt"; }
                    else if (upper == 15) { Upper = "Black T-Shirt"; }
                    else if (upper == 16) { Upper = "Burgundy T-Shirt"; }
                    else if (upper == 17) { Upper = "White T-Shirt"; }
                    else if (upper == 18) { Upper = "Gray T-Shirt"; }
                    else if (upper == 19) { Upper = "Pink T-Shirt"; }
                    else if (upper == 20) { Upper = "Blue T-Shirt"; }
                    Text += "Upper: " + Upper + "\n";
                }
                else if (upper_cloth == 3)
                {
                    if (upper == 0) { Upper = "Gray Tanktop"; }
                    else if (upper == 1) { Upper = "White Tanktop"; }
                    else if (upper == 2) { Upper = "White Tanktop"; }
                    else if (upper == 3) { Upper = "Gray Tanktop"; }
                    else if (upper == 4) { Upper = "Red Tanktop"; }
                    else if (upper == 5) { Upper = "Dark Blue Tanktop"; }
                    else if (upper == 6) { Upper = "Blue Tanktop"; }
                    else if (upper == 7) { Upper = "Pink Tanktop"; }
                    else if (upper == 8) { Upper = "Black Tanktop"; }
                    else if (upper == 9) { Upper = "Red Tanktop"; }
                    else if (upper == 10) { Upper = "Green Tanktop"; }
                    Text += "Upper: " + Upper + "\n";
                }
            }

            if (skin == 0 || skin == 1) { Skin = "Dark Skinned"; Text += "Skin Color: " + Skin + "\n "; }
            else if (skin >= 2) { Skin = "Light Skinned"; Text += "Skin Color: " + Skin + "\n "; }

            if (hair == 0) { Hair = "Dark"; Text += "Hair Color: " + Hair + "\n"; }
            else if (hair == 1) { Hair = "Brown"; Text += "Hair Color: " + Hair + "\n"; }
            else if (hair == 2) { Hair = "Blonde"; Text += "Hair Color: " + Hair + "\n"; }

            if (bool_shoe == true)
            {
                if (shoe_type == 0)
                {
                    if (shoe == 0) { Shoes = "White Sneakers"; }
                    else if (shoe == 1) { Shoes = "Pink Sneakers"; }
                    else if (shoe == 2) { Shoes = "Gray Sneakers"; }
                    else if (shoe == 3) { Shoes = "Brown Sneakers"; }
                    else if (shoe == 4) { Shoes = "Red Sneakers"; }
                    else if (shoe == 5) { Shoes = "Black Sneakers"; }
                    else if (shoe == 6) { Shoes = "Khaki Sneakers"; }
                    else if (shoe == 7) { Shoes = "Dark Gray Sneakers"; }
                    Text += "Shoes: " + Shoes + "\n";
                }
                else if (shoe_type == 1)
                {
                    if (shoe == 0) { Shoes = "Black Shoes"; }
                    else if (shoe == 1) { Shoes = "Pink Shoes"; }
                    else if (shoe == 2) { Shoes = "Cream Shoes"; }
                    else if (shoe == 3) { Shoes = "White Shoes"; }
                    else if (shoe == 4) { Shoes = "Red Shoes"; }
                    else if (shoe == 5) { Shoes = "Purple Shoes"; }
                    else if (shoe == 6) { Shoes = "Light Pink Shoes"; }
                    Text += "Shoes: " + Shoes + "\n";
                }
                else if (shoe_type == 2)
                {
                    if (shoe == 0) { Shoes = "Black Boots"; }
                    else if (shoe == 1) { Shoes = "Brown Boots"; }
                    else if (shoe == 2) { Shoes = "Green Boots"; }
                    else if (shoe == 3) { Shoes = "Pink Boots"; }
                    else if (shoe == 4) { Shoes = "Red Boots"; }
                    else if (shoe == 5) { Shoes = "Blue Boots"; }
                    Text += "Shoes: " + Shoes + "\n";
                }

            }

            if (glass == true) { Glasses = "Has Glasses"; Text += "Glasses: " + Glasses + "\n"; }

            if (scraf == true) { Scarf = "Has Scarf"; Text += "Scarf: " + Scarf + "\n"; }

            if (chani == true) { Chain = "Has Chain"; Text += "Chain: " + Chain + "\n"; }

            if (sex == 0) { Gender = "Boy"; Text += "Gender: " + Gender + "\n"; }
            else { Gender = "Girl"; Text += "Gender: " + Gender + "\n"; }


            text.text = Text;

        }
    }
}