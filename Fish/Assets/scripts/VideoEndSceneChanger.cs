using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEndSceneChanger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    void Start()
    {
        // VideoPlayer bile�enini ba�lay�n
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // VideoPlayer'�n loopPointReached etkinli�ine bir olay ekleyin
        videoPlayer.loopPointReached += OnVideoEnd;
    }
    void OnVideoEnd(VideoPlayer vp)
    {
        // Video bitti�inde bu fonksiyon �al��acak
        SceneManager.LoadScene("sahne2_son");
    }


}
