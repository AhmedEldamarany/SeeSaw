using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentQuestion", menuName = "CurrentQuestion")]

public class CurrentQuestion : ScriptableObject
{
    public QuestionSO data;
    public string tag;
    public static string right = "right";
    public static string left = "left";
        
}
