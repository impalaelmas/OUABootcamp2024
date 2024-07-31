using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collactableScript : MonoBehaviour
{
    scoreManager ScoreManager;

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
        }
        else if (other.CompareTag("destroy"))
        {
            Destroy(other.gameObject);
        }
    }
}


