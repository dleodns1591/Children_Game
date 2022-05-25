using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UI_Manager : MonoBehaviour
{

    [Header("게임시작 버튼")]
    public GameObject GameStart_Btn;
    [Header("제작자 버튼")]
    public GameObject Producer_Btn;
    [Header("제작자 창")]
    public GameObject Producer_Window;
    [Header("나가기 버튼")]
    public GameObject Exit_Btn;

    [Header("페이드인 아웃 배경")]
    public Image Fade_BackGround;

    void Start()
    {
        Fade_BackGround.GetComponent<Image>();
    }

    void Update()
    {
    }

    #region 씬 전환
    public void SceneChange_Chapter()
    {
        DontDestroyOnLoad(this.gameObject);
        StartCoroutine(FadeIn_Out());
    }

    private IEnumerator FadeIn_Out()
    {

        Fade_BackGround.raycastTarget = true;
        Fade_BackGround.DOFade(1f, 0.8f);
        yield return new WaitForSeconds(1f);
        Fade_BackGround.DOFade(0f, 1f);
        SceneManager.LoadScene("Chapter_Pick");
        Fade_BackGround.raycastTarget = false;
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }

    public void SceneChange_Ingame()
    {
        SceneManager.LoadScene("Ingame");
    }
    #endregion

    #region 제작자버튼 연출
    public void Producer()
    {
        // DOTween을 사용하여 X축으로 0.5초안에 지정한 위치로 이동시킨다.
        GameStart_Btn.transform.DOLocalMoveX(-1250, 0.5f).SetEase(Ease.InCirc);
        Producer_Btn.transform.DOLocalMoveX(1250, 0.5f).SetEase(Ease.InCirc);
        Exit_Btn.transform.DOLocalMoveX(-1250, 0.5f).SetEase(Ease.InCirc);

        // DOTween을 사용하여 크기 값을 1을 0.5초 안에 키워준다.
        Producer_Window.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    public void Producer_Close()
    {
        // DOTween을 사용하여 X축으로 0.5초안에 지정한 위치로 이동시킨다.
        GameStart_Btn.transform.DOLocalMoveX(0, 0.5f).SetEase(Ease.InCirc);
        Producer_Btn.transform.DOLocalMoveX(0, 0.5f).SetEase(Ease.InCirc);
        Exit_Btn.transform.DOLocalMoveX(0, 0.5f).SetEase(Ease.InCirc);

        // DOTween을 사용하여 크기 값을 0을 0.5초 안에 키워준다.
        Producer_Window.transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
    #endregion


    public void Exit()
    {
        Application.Quit();
    }
}
