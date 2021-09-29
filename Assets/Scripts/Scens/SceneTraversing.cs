using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTraversing : MonoBehaviour
{
    public void LoadHome()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void LoadGamePlay(int index)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(index);
    }
}
