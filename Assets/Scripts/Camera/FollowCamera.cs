using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;      // Player'�n Transform bilgilerini tutar.
    [SerializeField] private Vector3 offset;        // Player pozisyonuna eklenecek miktar.
    [SerializeField] private float timeSmooth;      // Takip etme yumu�akl���



    // Update is called once per frame
    void Update()
    {
        //Player pozisyonuna offset de�erleri eklenir.
        Vector3 cameraPosition = Vector3.Lerp(transform.position, player.position + offset, timeSmooth * Time.deltaTime);

        transform.position = cameraPosition;    // Camera pozisyonu ayarlan�r. 
    }

    public void SetOffset(Vector3 offsetValue)  // Offset de�erlerini de�i�tiren fonksiyon.
    {
        offset += offsetValue;
    }
}
