using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenQuestions : MonoBehaviour
{
   [SerializeField] public QuestionSO[] questions;
     void Start()
    {
        
        foreach(QuestionSO q in questions)
        Debug.Log(q.Word);
    }
}
