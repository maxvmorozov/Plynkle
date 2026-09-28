using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip CannonClip;
    public AudioClip PegDestroyedClip;
    public AudioClip PegHitClip;
    public AudioClip FireworkClip;
    
    private AudioSource audioSource;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayCannonSound()
    {
        audioSource.PlayOneShot(CannonClip);
    }

    public void PlayPegHitSound()
    {
        audioSource.PlayOneShot(PegHitClip);
    }
    
    public void PlayPegDestroyedSound()
    {
        audioSource.PlayOneShot(PegDestroyedClip);
    }
    
    public void PlayFireworkSound()
    {
        audioSource.PlayOneShot(FireworkClip);
    }
    
}
