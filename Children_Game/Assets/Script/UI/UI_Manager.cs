using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    #region ¾À ÀüÈ¯
    public void SceneChange_Chapter()
    {
        SceneManager.LoadScene("Chapter_Pick");
    }

    public void SceneChange_Ingame()
    {
        SceneManager.LoadScene("Ingame");
    }
    #endregion

    public void Exit()
    {
        Application.Quit();
    }
}
