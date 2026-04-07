using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

    [SerializeField] private AudioClip FlySound;
    [SerializeField] private AudioClip HitSound;
    [SerializeField] private AudioClip Score;
    [SerializeField] private AudioClip Die;

    private AudioSource audioSource;
    private void Awake()
    {
        instance = this;

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayFlyingSound() => audioSource.PlayOneShot(FlySound);
    public void PlayHitSound() => audioSource.PlayOneShot(HitSound);
    public void PlayScore() => audioSource.PlayOneShot(Score);
    public void PlayDie() => audioSource.PlayOneShot(Die);
}
