using UnityEngine;

public class FanusController : MonoBehaviour
{
    /* public int targetScore = 10;  // Skorun ula�mas� gereken de�er
     private skormanagement ScoreManager; // Skor y�neticisi

     void Start()
     {
         // ScoreManager referans�n� bul
         ScoreManager = GameObject.FindObjectOfType<skormanagement>();

         if (ScoreManager == null)
         {
             Debug.LogError("ScoreManager bulunamad�! L�tfen scoreManager scriptinin sahnede oldu�undan emin olun.");
         }
     }

     void Update()
     {
         // Skor kontrol� yaparak fanus objesini sil
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

    public int targetScore = 10;  // Skorun ula�mas� gereken de�er
    private skormanagement ScoreManager; // Skor y�neticisi

    void Start()
    {
        // ScoreManager referans�n� bul
        ScoreManager = GameObject.FindObjectOfType<skormanagement>();

        if (ScoreManager == null)
        {
            Debug.LogError("ScoreManager bulunamad�! L�tfen scoreManager scriptinin sahnede oldu�undan emin olun.");
        }
    }

    void Update()
    {
        // Skor kontrol� yaparak fanus objesini sil
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