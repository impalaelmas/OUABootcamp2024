using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class scoreManager : MonoBehaviour
{
    public int collectedObjectsCount = 0; // Toplanan nesne say�s�
    public GameObject triggerObject; // A��lacak nesne
    int score;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "Score: " + score;
        if (triggerObject != null)
        {
            triggerObject.SetActive(false); // Ba�lang��ta nesne kapal�
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

        collectedObjectsCount++; // Nesne topland���nda saya� art�r�l�r

        if (collectedObjectsCount >= 10)
        {
            OpenTriggerObject(); // Saya� 15'e ula�t���nda nesne a��l�r
        }
      
    }

    void OpenTriggerObject()
    {
        if (triggerObject != null)
        {
            triggerObject.SetActive(true); // Nesne a��l�r
        }
    }
 
}