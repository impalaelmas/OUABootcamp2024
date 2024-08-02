using UnityEngine;

public class trigerControll : MonoBehaviour
{
    public Collider targetCollider;  // Trigger'� a��lacak objenin collider'�
    public int targetScore = 10;      // Trigger'�n a��laca�� skor
    private skormanagement ScoreManager; // Skor y�neticisi

    void Start()
    {
        // Ba�lang��ta targetCollider'�n trigger'�n� kapal� yap�n
        if (targetCollider != null)
        {
            targetCollider.isTrigger = false;
        }

        // ScoreManager referans�n� bul
        ScoreManager = GameObject.FindObjectOfType<skormanagement>();

        if (ScoreManager == null)
        {
            Debug.LogError("ScoreManager bulunamad�! L�tfen scoreManager scriptinin sahnede oldu�undan emin olun.");
        }
    }

    void Update()
    {
        // Skor kontrol� yaparak targetCollider'� trigger olarak a�
        if (ScoreManager != null && ScoreManager.GetCurrentScore() >= targetScore)
        {
            if (targetCollider != null)
            {
                targetCollider.isTrigger = true;
            }
        }
    }
}