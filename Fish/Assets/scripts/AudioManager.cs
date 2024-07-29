using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------Audio Source------")]
    [SerializeField] AudioSource SFXSource;

    [Header("-------Audio Clip------")]
    public AudioClip Coin;


    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
