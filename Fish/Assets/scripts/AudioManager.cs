using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    [Header("-------Audio Source------")]
    [SerializeField] AudioSource SFXSource;
 


    [Header("-------Audio Clip------")]
    public AudioClip Coin;
    public AudioClip Jump;
    public AudioClip PortalOpen;


    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }


}
