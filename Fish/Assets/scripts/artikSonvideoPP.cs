using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoSceneChanger : MonoBehaviour
{
    public VideoPlayer videoPlayer; // VideoPlayer bile�eni buraya atanacak
    public string sceneToLoad; // Y�klenecek sahnenin ad�

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd; // Video bitti�inde OnVideoEnd metodunu �a��r
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneToLoad); // Belirtilen sahneyi y�kle
    }
}
