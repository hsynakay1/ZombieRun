using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 10f;
    [SerializeField] private float sideSpeed = 10f;

    [SerializeField] private float wayHalf = 4f;



    // Update is called once per frame
    void Update()
    {
        float side = Input.GetAxis("Horizontal") * sideSpeed * Time.deltaTime;

        transform.Translate(side, 0f, forwardSpeed * Time.deltaTime);

        if (transform.position.x <= -wayHalf)
        {
            Vector3 _position = new Vector3(-wayHalf, transform.position.y, transform.position.z);
            transform.position = _position;
        }
        else if (transform.position.x >= wayHalf)
        {
            Vector3 _position = new Vector3(wayHalf, transform.position.y, transform.position.z);
            transform.position = _position;
        }
    }
}
