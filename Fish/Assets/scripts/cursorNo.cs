using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorNo : MonoBehaviour
{
    void Start()
    {
        // Cursor'u gizle ve hareket etmesini engelle
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Oyun sýrasýnda ESC tuþuna basýlýrsa imleci tekrar görünür hale getirmek için
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}