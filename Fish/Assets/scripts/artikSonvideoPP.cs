using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoSceneChanger : MonoBehaviour
{
    public VideoPlayer videoPlayer; // VideoPlayer bileþeni buraya atanacak
    public string sceneToLoad; // Yüklenecek sahnenin adý

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd; // Video bittiðinde OnVideoEnd metodunu çaðýr
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneToLoad); // Belirtilen sahneyi yükle
    }
}
