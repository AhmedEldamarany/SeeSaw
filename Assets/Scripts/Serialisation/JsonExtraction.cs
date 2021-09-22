using System;
using UnityEngine;

public class JsonExtraction : MonoBehaviour
{
    [SerializeField] TextAsset JsonFile;
    [SerializeField] QuestionList newQuestionList;
    void Start()
    {
        Root root = JsonUtility.FromJson<Root>(JsonFile.text);
        newQuestionList.init(root.activity.questions.question.Length);
        foreach (Question question in root.activity.questions.question)
        {
            newQuestionList.Add(question.wrd, question.img, question.snd);
        }

    }
}
#region json claases
[Serializable]
public class Question
{
    public string img;
    public string snd;
    public string wrd;
}

[Serializable]

public class Questions
{
    public Question[] question;
}

[Serializable]

public class Activity
{
    public Questions questions;
    public string name;
    public string mode;
    public string randomizeOrder;
}

[Serializable]

public class Root
{
    public Activity activity;

}

#endregion