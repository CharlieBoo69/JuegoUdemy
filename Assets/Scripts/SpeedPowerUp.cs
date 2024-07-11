using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float speedIncrease = 2f;
    public float duration = 5f;
    private Vector3 originalSize;
    private Vector3 increasedSize;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        PlayerController playerController = player.GetComponent<PlayerController>();
        playerController.speed *= speedIncrease;

        // Guardar el tamaño original del jugador
        originalSize = player.transform.localScale;

        // Calcular el tamaño aumentado (50% más grande que el tamaño original)
        increasedSize = originalSize * 1.5f;

        // Aumentar el tamaño del jugador
        player.transform.localScale = increasedSize;

        // Desactivar visualmente el power-up
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // Esperar por la duración del power-up
        yield return new WaitForSeconds(duration);

        // Revertir el efecto del power-up
        playerController.speed /= speedIncrease;
        player.transform.localScale = originalSize; // Volver al tamaño original

        // Destruir el objeto del power-up
        Destroy(gameObject);
    }
}
