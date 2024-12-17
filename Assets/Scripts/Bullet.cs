using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target") || collision.gameObject.CompareTag("Innocent"))
        {
            Animator NpcAnimator = collision.transform.GetChild(0).GetComponent<Animator>();
            NpcAnimator.enabled = false;
            NavMeshAgent navMeshAgent = collision.gameObject.GetComponent<NavMeshAgent>();
            navMeshAgent.enabled = false;
            Test_script testScript = collision.gameObject.GetComponent<Test_script>();
            testScript.enabled = false;
            BoxCollider NpcBoxCollider = collision.gameObject.GetComponent<BoxCollider>();
            NpcBoxCollider.enabled = false;
 
            Ragdolls ragdollController = collision.transform.GetChild(0).GetComponent<Ragdolls>(); 
            if (ragdollController != null)
            {
                ragdollController.EnableRagdolls();
            }
            if (collision.gameObject.CompareTag("Target"))
            {
                GameManager.Instance.TargetKilled();

            }
            else if (collision.gameObject.CompareTag("Innocent"))
            {
                GameManager.Instance.InnocentKilled();
            }
        }
        Destroy(gameObject);
    }
}


