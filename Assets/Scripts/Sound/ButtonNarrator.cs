using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNarrator : MonoBehaviour
{
    [SerializeField] CurrentQuestion currentQuestion;
    AudioSource source;
    [SerializeField] Sprite Active;
    [SerializeField] Sprite Idle;
    Image image;
    Button button;
    void Start()
    {
        source = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        button = GetComponent<Button>();

    }
    public bool IsPlaying()
    {
        return source.isPlaying;
    }
    public void PlayCurrentWord()
    {
        if (currentQuestion.data != null)
            source.PlayOneShot(currentQuestion.data.Sound);

    }
    public void  PlayUponClicking()
    {
        PlayCurrentWord();
        image.sprite = Idle;
        button.interactable = false;
        StartCoroutine("finishPlaying");
       
    }
    public IEnumerator finishPlaying()
    {
        while (source.isPlaying)
            yield return null;
        image.sprite = Active;
        button.interactable = true;

    }
}
