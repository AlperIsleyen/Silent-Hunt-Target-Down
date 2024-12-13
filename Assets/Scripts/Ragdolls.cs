using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Ragdolls : MonoBehaviour
 
{
    public Rigidbody[] rigidbodies;
 
    public void EnableRagdolls()
    {
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = false;
        }
    }
}