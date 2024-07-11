using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform laserSpawnPoint;
    public float laserSpeed = 20f;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject laser = Instantiate(laserPrefab, laserSpawnPoint.position, laserSpawnPoint.rotation);
        Rigidbody rb = laser.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * laserSpeed;

        // Reproducir el sonido del disparo
        audioSource.Play();
    }
}
