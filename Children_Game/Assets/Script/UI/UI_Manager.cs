using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UI_Manager : MonoBehaviour
{

    [Header("���ӽ��� ��ư")]
    public GameObject GameStart_Btn;
    [Header("������ ��ư")]
    public GameObject Producer_Btn;
    [Header("������ â")]
    public GameObject Producer_Window;
    [Header("������ ��ư")]
    public GameObject Exit_Btn;

    [Header("���̵��� �ƿ� ���")]
    public Image Fade_BackGround;

    void Start()
    {
        Fade_BackGround.GetComponent<Image>();
    }

    void Update()
    {
    }

    #region �� ��ȯ
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

    #region �����ڹ�ư ����
    public void Producer()
    {
        // DOTween�� ����Ͽ� X������ 0.5�ʾȿ� ������ ��ġ�� �̵���Ų��.
        GameStart_Btn.transform.DOLocalMoveX(-1250, 0.5f).SetEase(Ease.InCirc);
        Producer_Btn.transform.DOLocalMoveX(1250, 0.5f).SetEase(Ease.InCirc);
        Exit_Btn.transform.DOLocalMoveX(-1250, 0.5f).SetEase(Ease.InCirc);

        // DOTween�� ����Ͽ� ũ�� ���� 1�� 0.5�� �ȿ� Ű���ش�.
        Producer_Window.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    public void Producer_Close()
    {
        // DOTween�� ����Ͽ� X������ 0.5�ʾȿ� ������ ��ġ�� �̵���Ų��.
        GameStart_Btn.transform.DOLocalMoveX(0, 0.5f).SetEase(Ease.InCirc);
        Producer_Btn.transform.DOLocalMoveX(0, 0.5f).SetEase(Ease.InCirc);
        Exit_Btn.transform.DOLocalMoveX(0, 0.5f).SetEase(Ease.InCirc);

        // DOTween�� ����Ͽ� ũ�� ���� 0�� 0.5�� �ȿ� Ű���ش�.
        Producer_Window.transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
    #endregion


    public void Exit()
    {
        Application.Quit();
    }
}
