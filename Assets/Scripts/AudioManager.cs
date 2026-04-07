using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    
    [SerializeField] private AudioClip flySound;
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip scoreSound;
    [SerializeField] private AudioClip dieSound;

    private AudioSource _audioSource;
    
    void Awake()
    {
        Instance = this;
        
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayFlyingSound() => _audioSource.PlayOneShot(flySound);
    public void PlayHitSound() => _audioSource.PlayOneShot(hitSound);
    public void PlayScore() => _audioSource.PlayOneShot(scoreSound);
    public void PlayDieSound() => _audioSource.PlayOneShot(dieSound);
}
