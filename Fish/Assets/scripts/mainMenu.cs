using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButon : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void InformPP()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}