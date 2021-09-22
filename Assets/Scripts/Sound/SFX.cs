using UnityEngine;

public class SFX : MonoBehaviour
{
    [SerializeField] AudioClip win;
    [SerializeField] AudioClip lose;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void playWin(bool isWin)
    {
        source.Stop();
        if (isWin)
            source.clip = win;

        else
            source.clip = lose;

        source.Play();
    }
    public bool IsPlaying()
    {
        return source.isPlaying;
    }
}
