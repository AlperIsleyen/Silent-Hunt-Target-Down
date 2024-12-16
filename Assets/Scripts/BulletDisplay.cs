using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BulletDisplay : MonoBehaviour
{
    public int bullet;
    public static BulletDisplay Instance;
    public TMP_Text text;
    public void SetBulletCount(int int_bullet)
    {
        text.text = string.Format("{0/0}", int_bullet);
    }
}
