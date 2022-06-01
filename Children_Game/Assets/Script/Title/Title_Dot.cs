using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Dot : MonoBehaviour
{
    [Header("지구")]
    public GameObject Earth;

    [Header("지구의 회전 속도")]
    public float Earth_Speed;

    [Header("구름")]
    public RectTransform Cloud_01;
    public RectTransform Cloud_02;
    public RectTransform Cloud_03;
    public RectTransform Cloud_04;

    [Header("터치 후 게임 시작")]
    public Image Touch_Start;
    public float Start_Num = 0;

    [Header("타이틀 & 부제목")]
    public RectTransform Title;

    [Header("챕터 창")]
    public RectTransform Chapter_Window;

    void Start()
    {

        Cloud_Dot();
        TouchStart_Dot();
    }

    void Update()
    {
        Earth_Dot();
    }

    public void Earth_Dot()
    {
        Earth.transform.Rotate(Vector3.up * Time.deltaTime * Earth_Speed);
    }

    public void Cloud_Dot()
    {
        StartCoroutine(Move_Cloud());
    }

    public void TouchStart_Dot()
    {
        StartCoroutine(StartTxt_FadeIn());
    }

    public void StartClick_Dot()
    {
        if (Start_Num == 0)
        {
            Start_Num += 1;
            StopCoroutine(Move_Cloud());
            StopCoroutine(ComeBack_Cloud());
            StartCoroutine(Start_Clcick());
        }

    }

    #region 구름 이동
    public IEnumerator Move_Cloud()
    {
        if (Start_Num == 0)
        {
            Cloud_01.DOAnchorPosX(-872, 1f).SetEase(Ease.InOutQuad);
            Cloud_01.DOAnchorPosY(293, 1f).SetEase(Ease.InOutQuad);

            Cloud_02.DOAnchorPosX(865, 1f).SetEase(Ease.InOutQuad);
            Cloud_02.DOAnchorPosY(375, 1f).SetEase(Ease.InOutQuad);

            Cloud_03.DOAnchorPosX(-755, 1f).SetEase(Ease.InOutQuad);
            Cloud_03.DOAnchorPosY(-472, 1f).SetEase(Ease.InOutQuad);

            Cloud_04.DOAnchorPosX(690, 1f).SetEase(Ease.InOutQuad);
            Cloud_04.DOAnchorPosY(-412, 1f).SetEase(Ease.InOutQuad);
            yield return new WaitForSeconds(1.5f);
            StartCoroutine(ComeBack_Cloud());
        }
    }

    public IEnumerator ComeBack_Cloud()
    {
        if (Start_Num == 0)
        {
            Cloud_01.DOAnchorPosX(-761, 1f).SetEase(Ease.InOutQuad);
            Cloud_01.DOAnchorPosY(453, 1f).SetEase(Ease.InOutQuad);

            Cloud_02.DOAnchorPosX(727, 1f).SetEase(Ease.InOutQuad);
            Cloud_02.DOAnchorPosY(481, 1f).SetEase(Ease.InOutQuad);

            Cloud_03.DOAnchorPosX(-667, 1f).SetEase(Ease.InOutQuad);
            Cloud_03.DOAnchorPosY(-519, 1f).SetEase(Ease.InOutQuad);

            Cloud_04.DOAnchorPosX(640, 1f).SetEase(Ease.InOutQuad);
            Cloud_04.DOAnchorPosY(-489, 1f).SetEase(Ease.InOutQuad);
            yield return new WaitForSeconds(1.5f);
            StartCoroutine(Move_Cloud());
        }

    }
    #endregion

    #region 게임시작 글씨 FadeInOut

    public IEnumerator StartTxt_FadeIn()
    {
        Touch_Start.DOFade(0f, 1f);
        yield return new WaitForSeconds(1f);
        StartCoroutine(StartTxt_FadeOut());
    }

    public IEnumerator StartTxt_FadeOut()
    {
        if (Start_Num == 0)
        {
            Touch_Start.DOFade(1f, 1f);
            yield return new WaitForSeconds(1f);
            StartCoroutine(StartTxt_FadeIn());
        }
    }

    #endregion

    #region 게임시작 클릭

    public IEnumerator Start_Clcick()
    {
        // 닷트윈을 통하여 구름(1, 2, 3, 4) X축으로 이동
        Cloud_01.DOAnchorPosX(-1450, 1f).SetEase(Ease.InOutExpo);
        Cloud_02.DOAnchorPosX(1537, 1f).SetEase(Ease.InOutExpo);
        Cloud_03.DOAnchorPosX(-1450, 1f).SetEase(Ease.InOutExpo);
        Cloud_04.DOAnchorPosX(1537, 1f).SetEase(Ease.InOutExpo);

        // 1초 대기
        yield return new WaitForSeconds(1f);

        // 닷트윈을 통하여 타이틀 Y축으로 이동
        Title.DOAnchorPosY(700, 1f).SetEase(Ease.InOutBack);

        // 0.5초 대기
        yield return new WaitForSeconds(0.5f);

        // 닷트윈을 통하여 챕터 창 X축으로 이동
        Chapter_Window.DOAnchorPosX(561, 1f).SetEase(Ease.OutBounce);

    }


    #endregion

}
