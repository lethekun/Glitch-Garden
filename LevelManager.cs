using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    private float waitingSplashTime = 3f;

    void Start()
    {
        if(Application.loadedLevel == 0)
        Invoke("LoadNextLevel", waitingSplashTime);
    }

    public void LoadLevel(string name)
    {
        //Debug.Log ("New Level load: " + name);
        Application.LoadLevel(name);
    }

    public void QuitRequest()
    {
        //Debug.Log ("Quit requested");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

}