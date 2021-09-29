using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionList", menuName = "Question List")]
public class QuestionList : ScriptableObject
{
    public int index { private set; get; }
    Sprite[] images;
    AudioClip[] sounds;
    string[] words;
    int fillingIndex;
    private void OnEnable()
    {
        index = 0;
    }
    public int Count()
    {
        return fillingIndex;
    }


    public void init(int size)
    {
        images = new Sprite[size];
        sounds = new AudioClip[size];
        words = new string[size];
        fillingIndex = 0;
    }
    public void MoveForward()
    {
        index++;

    }

    public void Add(string word, string imgPath, string audioPath)
    {
        images[fillingIndex] = Resources.Load<Sprite>($"img/{ imgPath.Substring(0, imgPath.LastIndexOf('.'))}");
        sounds[fillingIndex] = Resources.Load<AudioClip>($"snd/{audioPath.Substring(0, audioPath.LastIndexOf('.'))}");
        words[fillingIndex] = word;
        fillingIndex++;
    }
    #region Read from persistentDataPath
    //public void Add(string word, string imgPath, string audioPath)
    //{
    //    LoadSprite(imgPath);
    //    LoadAudio(audioPath);
    //    words[fillingIndex] = word;
    //    fillingIndex++;
    //}

    private void LoadSprite(string imgpath)
    {
        string path = Application.persistentDataPath + $"//img/{imgpath}";
        if (string.IsNullOrEmpty(path)) return;
        if (System.IO.File.Exists(path))
        {
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            Texture2D texture = new Texture2D(1, 1);
            texture.LoadImage(bytes);
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            images[fillingIndex] = sprite;
        }
        return;
    }

    IEnumerator LoadAudio(string audioPath)
    {
        string url = "file://" + Application.persistentDataPath + $"//snd/{audioPath}";
        WWW www = new WWW(url);
        yield return www;
        AudioClip audioClip = www.GetAudioClip(false, true);
        sounds[fillingIndex] = audioClip;
    }

    #endregion
    public QuestionSO GetCurrent()
    {
        if (index < fillingIndex)
        {
            return new QuestionSO(words[index], images[index], sounds[index]);
        }
        else
            return null;

    }

    public QuestionSO GetRandom()
    {
        int rand = Random.Range(0, fillingIndex);
        if (rand != index)
            return new QuestionSO(words[rand], images[rand], sounds[rand]);
        else if (fillingIndex > 1)
        {
            if (index == 0)
                return new QuestionSO(words[1], images[1], sounds[1]);
            else
                return new QuestionSO(words[index - 1], images[index - 1], sounds[index - 1]);
        }
        else
        {
            Debug.LogWarning("The List has only one question");
            return new QuestionSO(words[index], images[index], sounds[index]);
        }
    }

}
