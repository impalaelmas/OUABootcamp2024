using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collactableScript : MonoBehaviour
{
    scoreManager ScoreManager;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        ScoreManager = GameObject.Find("Canvas").GetComponent<scoreManager>();
 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.IncreaseScore();
            gameObject.SetActive(false);
            audioManager.PlaySFX(audioManager.Coin);
        }
        else if (other.CompareTag("destroy"))
        {
            Destroy(other.gameObject);
        }
    }
}


