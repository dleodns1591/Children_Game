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

    public IEnumerator FadeInOut_Coroutine()
    {
        Fade.DOFade(1, 1f);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage_01");
        yield return new WaitForSeconds(0.5f);
        Fade.DOFade(0f, 1f);
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
