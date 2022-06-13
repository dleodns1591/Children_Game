using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInOut : MonoBehaviour
{
    public Image Fade;

    void Start()
    {

    }

    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Fade_InOut()
    {
        StartCoroutine(FadeInOut_Coroutine());
    }

    #region 페이드인아웃
    public IEnumerator FadeInOut_Coroutine()
    {
        Fade.DOFade(1, 1f);
        yield return new WaitForSeconds(1f);
        if (SceneManager.GetActiveScene().name == "Title")
        {
            SceneManager.LoadScene("Stage_01");
        }
        else if (SceneManager.GetActiveScene().name == "Stage_01")
        {
            SceneManager.LoadScene("Stage_02");
        }
        else if (SceneManager.GetActiveScene().name == "Stage_02")
        {
            SceneManager.LoadScene("Title");
        }
        yield return new WaitForSeconds(0.5f);
        Fade.DOFade(0f, 1f);
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
    #endregion
}
