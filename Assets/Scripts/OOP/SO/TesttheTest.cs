using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesttheTest : MonoBehaviour
{
    [SerializeField] ListOfClassesTestSO list;
    void Start()
    {
        list.SaveData();
        foreach(thing t in list.things)
            Debug.Log(t.number);
    }

   
}
