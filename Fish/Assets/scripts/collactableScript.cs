using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collactableScript : MonoBehaviour
{
    scoreManager ScoreManager;
    public AudioClip collectSound;
    private AudioSource audioSource;


    void Start()
    {
        // AudioSource bileþenini bulun
        audioSource = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
        ScoreManager = GameObject.Find("Canvas").GetComponent<scoreManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Ses efektini çal
            audioSource.PlayOneShot(collectSound);

            ScoreManager.IncreaseScore();
            gameObject.SetActive(false);


        }
        else if (other.CompareTag("destroy"))
        {
            Destroy(other.gameObject);
        }
    }
}
