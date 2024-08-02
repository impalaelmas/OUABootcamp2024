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
        // Oyun s�ras�nda ESC tu�una bas�l�rsa imleci tekrar g�r�n�r hale getirmek i�in
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}