using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;      // Player'ýn Transform bilgilerini tutar.
    [SerializeField] private Vector3 offset;        // Player pozisyonuna eklenecek miktar.
    [SerializeField] private float timeSmooth;      // Takip etme yumuþaklýðý



    // Update is called once per frame
    void Update()
    {
        //Player pozisyonuna offset deðerleri eklenir.
        Vector3 cameraPosition = Vector3.Lerp(transform.position, player.position + offset, timeSmooth * Time.deltaTime);

        transform.position = cameraPosition;    // Camera pozisyonu ayarlanýr. 
    }

    public void SetOffset(Vector3 offsetValue)  // Offset deðerlerini deðiþtiren fonksiyon.
    {
        offset += offsetValue;
    }
}
