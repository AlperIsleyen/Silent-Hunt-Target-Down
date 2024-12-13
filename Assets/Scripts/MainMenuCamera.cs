using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MainMenuCamera : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
 
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}