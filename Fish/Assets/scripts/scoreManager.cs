using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class scoreManager : MonoBehaviour
{
    public int collectedObjectsCount = 0; // Toplanan nesne sayýsý
    public GameObject triggerObject; // Açýlacak nesne
    int score;
    [SerializeField] TextMeshProUGUI scoreText;
    void Start()
    {
       
        scoreText.text = "Score: " + score;
        if (triggerObject != null)
        {
            triggerObject.SetActive(false); // Baþlangýçta nesne kapalý
        }
        else
        {
            Debug.LogError("Trigger Object is not assigned.");
        }
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        collectedObjectsCount++; // Nesne toplandýðýnda sayaç artýrýlýr
        if (collectedObjectsCount >= 10)
        {
            OpenTriggerObject(); // Sayaç 15'e ulaþtýðýnda nesne açýlýr
        }
      
    }

    void OpenTriggerObject()
    {
        if (triggerObject != null)
        {
            triggerObject.SetActive(true); // Nesne açýlýr
        }
    }
 
}