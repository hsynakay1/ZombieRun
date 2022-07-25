using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float fireTime = 0.5f;
    [SerializeField] private float projectileForce = 1000f;

    [SerializeField] private Transform muzzle;

    private float totalFireTime;
    private bool isFire = true;

    private MeshRenderer meshRenderComponent;

    private Rigidbody rigidBody;
    private SphereCollider colliderComponent;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        meshRenderComponent = GetComponent<MeshRenderer>();
        colliderComponent = GetComponent<SphereCollider>();
    }

    private void Start()
    {
        //gameObject.SetActive(false);
    }

    


    // Update is called once per frame
    void Update()
    {
        if(isFire && Time.time > totalFireTime)
        {
            meshRenderComponent.enabled = true;
            colliderComponent.enabled = true;

            rigidBody.AddForce(Vector3.forward * projectileForce, ForceMode.Impulse);

            totalFireTime = Time.time + fireTime;

            Invoke(nameof(SetPosition), fireTime);
        }
        


    }

    void SetPosition()
    {
        rigidBody.velocity = Vector3.zero;
        transform.position = muzzle.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("Enemy"))
        {
            colliderComponent.enabled = false;
            meshRenderComponent.enabled = false;
            SetPosition();

            Destroy(other.gameObject);
        }
    }
}
