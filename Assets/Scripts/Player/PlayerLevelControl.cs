using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLevelControl : MonoBehaviour
{
    [SerializeField] private GameObject[] guns;

    
    [SerializeField] private TMPro_Text  totalYearText;

    private int index;
    private int totalYears = 1500;


    private void Start()
    {
       totalYearText.text = totalYears.ToString(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("upgrade") || other.transform.CompareTag("downgrade"))
        {

            int yearOffset = other.transform.GetComponent<Door>().yearsValue;

            totalYears += yearOffset;

            SetPlayerLevel(totalYears);

            Debug.Log(totalYears);
        }
 
    }

    void SetPlayerLevel(int years)
    {
        if(years > 1000 && years < 1600)
        {
            index = 0;
        }
        else if (years >= 1600 && years < 1800)
        {
            index = 1;
        }
        else if (years > 1800)
        {
            index = 2;
        }

        foreach (GameObject item in guns)
        {
            item.SetActive(false);
        }

        guns[index].SetActive(true);
        totalYearText.text = totalYears.ToString();
    }
}
