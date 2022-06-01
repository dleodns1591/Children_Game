using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Dot : MonoBehaviour
{
    [Header("����")]
    public GameObject Earth;

    [Header("������ ȸ�� �ӵ�")]
    public float Earth_Speed;

    [Header("����")]
    public RectTransform Cloud_01;
    public RectTransform Cloud_02;
    public RectTransform Cloud_03;
    public RectTransform Cloud_04;

    [Header("��ġ �� ���� ����")]
    public Image Touch_Start;
    public float Start_Num = 0;

    [Header("Ÿ��Ʋ & ������")]
    public RectTransform Title;

    [Header("é�� â")]
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

    #region ���� �̵�
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

    #region ���ӽ��� �۾� FadeInOut

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

    #region ���ӽ��� Ŭ��

    public IEnumerator Start_Clcick()
    {
        // ��Ʈ���� ���Ͽ� ����(1, 2, 3, 4) X������ �̵�
        Cloud_01.DOAnchorPosX(-1450, 1f).SetEase(Ease.InOutExpo);
        Cloud_02.DOAnchorPosX(1537, 1f).SetEase(Ease.InOutExpo);
        Cloud_03.DOAnchorPosX(-1450, 1f).SetEase(Ease.InOutExpo);
        Cloud_04.DOAnchorPosX(1537, 1f).SetEase(Ease.InOutExpo);

        // 1�� ���
        yield return new WaitForSeconds(1f);

        // ��Ʈ���� ���Ͽ� Ÿ��Ʋ Y������ �̵�
        Title.DOAnchorPosY(700, 1f).SetEase(Ease.InOutBack);

        // 0.5�� ���
        yield return new WaitForSeconds(0.5f);

        // ��Ʈ���� ���Ͽ� é�� â X������ �̵�
        Chapter_Window.DOAnchorPosX(561, 1f).SetEase(Ease.OutBounce);

    }


    #endregion

}
