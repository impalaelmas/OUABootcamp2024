using UnityEngine;

public class trigerControll : MonoBehaviour
{
    public Collider targetCollider;  // Trigger'ý açýlacak objenin collider'ý
    public int targetScore = 10;      // Trigger'ýn açýlacaðý skor
    private skormanagement ScoreManager; // Skor yöneticisi

    void Start()
    {
        // Baþlangýçta targetCollider'ýn trigger'ýný kapalý yapýn
        if (targetCollider != null)
        {
            targetCollider.isTrigger = false;
        }

        // ScoreManager referansýný bul
        ScoreManager = GameObject.FindObjectOfType<skormanagement>();

        if (ScoreManager == null)
        {
            Debug.LogError("ScoreManager bulunamadý! Lütfen scoreManager scriptinin sahnede olduðundan emin olun.");
        }
    }

    void Update()
    {
        // Skor kontrolü yaparak targetCollider'ý trigger olarak aç
        if (ScoreManager != null && ScoreManager.GetCurrentScore() >= targetScore)
        {
            if (targetCollider != null)
            {
                targetCollider.isTrigger = true;
            }
        }
    }
}