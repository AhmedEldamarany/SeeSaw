using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyToggle : MonoBehaviour
{
    [SerializeField] GameObject ObjectToToggle;
   
    public void Toggle()
    {
        if (ObjectToToggle.activeInHierarchy)
            ObjectToToggle.SetActive(false);
        else 
            ObjectToToggle.SetActive(true);
    }

}
