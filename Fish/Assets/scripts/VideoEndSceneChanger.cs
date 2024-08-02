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
        // VideoPlayer bileþenini baðlayýn
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // VideoPlayer'ýn loopPointReached etkinliðine bir olay ekleyin
        videoPlayer.loopPointReached += OnVideoEnd;
    }
    void OnVideoEnd(VideoPlayer vp)
    {
        // Video bittiðinde bu fonksiyon çalýþacak
        SceneManager.LoadScene("sahne2_son");
    }


}
