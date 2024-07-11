using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Láser ha colisionado con: " + other.name); // Añadir mensaje de depuración

        if (other.CompareTag("Destructible"))
        {
            Debug.Log("Objeto destructible detectado: " + other.name); // Añadir mensaje de depuración
            Destroy(other.gameObject); // Destruir el objeto con el tag "Destructible"
            Destroy(gameObject); // Destruir el láser
        }
    }
}