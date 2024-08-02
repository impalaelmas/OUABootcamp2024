using UnityEngine;

public class FanusController : MonoBehaviour
{
    /* public int targetScore = 10;  // Skorun ulaþmasý gereken deðer
     private skormanagement ScoreManager; // Skor yöneticisi

     void Start()
     {
         // ScoreManager referansýný bul
         ScoreManager = GameObject.FindObjectOfType<skormanagement>();

         if (ScoreManager == null)
         {
             Debug.LogError("ScoreManager bulunamadý! Lütfen scoreManager scriptinin sahnede olduðundan emin olun.");
         }
     }

     void Update()
     {
         // Skor kontrolü yaparak fanus objesini sil
         if (ScoreManager != null && ScoreManager.GetCurrentScore() >= targetScore)
         {
             // Fanus objesini sahneden sil
             GameObject fanus = GameObject.FindGameObjectWithTag("Fanus");
             if (fanus != null)
             {
                 Destroy(fanus);
                 Debug.Log("Fanus objesi silindi.");
             }
         }
     }*/

    public int targetScore = 10;  // Skorun ulaþmasý gereken deðer
    private skormanagement ScoreManager; // Skor yöneticisi

    void Start()
    {
        // ScoreManager referansýný bul
        ScoreManager = GameObject.FindObjectOfType<skormanagement>();

        if (ScoreManager == null)
        {
            Debug.LogError("ScoreManager bulunamadý! Lütfen scoreManager scriptinin sahnede olduðundan emin olun.");
        }
    }

    void Update()
    {
        // Skor kontrolü yaparak fanus objesini sil
        if (ScoreManager != null && ScoreManager.GetCurrentScore() >= targetScore)
        {
            // Fanus objesini sahneden sil
            GameObject fanus = GameObject.FindGameObjectWithTag("Fanus");
            if (fanus != null)
            {
                Destroy(fanus);
                Debug.Log("Fanus objesi silindi.");
            }
        }
    }
}