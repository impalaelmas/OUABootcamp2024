using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class skormanagement : MonoBehaviour
{
    /*  public int collectedObjectsCount = 0; // Toplanan nesne sayýsý
      [SerializeField] TextMeshProUGUI scoreText;
      public int currentScore = 0;
      int score;

      private void Start()
      {
          // scoreText.text = "Score: " + score;
      }
      public void IncreaseScore()
      {
          score++;
          scoreText.text = "Score: " + score;

          collectedObjectsCount++; // Nesne toplandýðýnda sayaç artýrýlýr
          currentScore++;
      }


      public int GetCurrentScore()
      {
          return currentScore;
      }*/


    public int currentScore = 0;

    public void IncreaseScore()
    {
        currentScore++;
        Debug.Log("Skor artýrýldý: " + currentScore);
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}