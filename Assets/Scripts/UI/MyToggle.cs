using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyToggle : MonoBehaviour
{
    [SerializeField] GameObject ObjectToToggle;
    [SerializeField] GameObject ObjectToToggle2;
   
    public void Toggle()
    {
        if (ObjectToToggle.activeInHierarchy)
            ObjectToToggle.SetActive(false);
        else 
            ObjectToToggle.SetActive(true);
    }
    public void ToggleBoth()
    {
        Toggle();
        if (ObjectToToggle2.activeInHierarchy)
            ObjectToToggle2.SetActive(false);
        else
            ObjectToToggle2.SetActive(true);
    }
}
