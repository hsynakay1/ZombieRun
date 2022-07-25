using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Area : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            foreach (GameObject item in enemies)
            {
                Enemy enemyScript = item.GetComponent<Enemy>();
                enemyScript.enabled = true;
                
            }
        }
    }
}
