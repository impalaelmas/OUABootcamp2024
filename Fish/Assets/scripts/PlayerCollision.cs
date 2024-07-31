using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �arp��man�n oldu�u objenin tag'i "Destroyable" ise
        if (other.CompareTag("Destroyable"))
        {
            // Objeyi sahneden sil
            Destroy(other.gameObject);
        }
    }
}
