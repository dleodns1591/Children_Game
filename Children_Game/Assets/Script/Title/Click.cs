using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Chapter_Pick");
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
