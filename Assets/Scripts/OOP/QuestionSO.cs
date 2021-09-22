using UnityEngine;

public class QuestionSO
{
    string word;
    AudioClip sound;
    Sprite img;
    public QuestionSO(string word, Sprite image, AudioClip sound)
    {
        this.word = word;
        this.img = image;
        this.sound = sound;
    }

    public string Word { get => word; set => word = value; }
    public AudioClip Sound { get => sound; set => sound = value; }
    public Sprite Img { get => img; set => img = value; }
}
