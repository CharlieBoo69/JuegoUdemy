using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("L�ser ha colisionado con: " + other.name); // A�adir mensaje de depuraci�n

        if (other.CompareTag("Destructible"))
        {
            Debug.Log("Objeto destructible detectado: " + other.name); // A�adir mensaje de depuraci�n
            Destroy(other.gameObject); // Destruir el objeto con el tag "Destructible"
            Destroy(gameObject); // Destruir el l�ser
        }
    }
}