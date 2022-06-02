using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage_01 : MonoBehaviour
{
    [Header("도형 순서")]
    public int rand;
    private bool[] clear = new bool[3];

    [Header("도형")]
    public GameObject Shape_Circle;
    public GameObject Shape_Rectangle;
    public GameObject Shape_Triangle;

    [Header("다음 스테이지 버튼")]
    public RectTransform NextStage;

    [Header("페이드인아웃")]
    public Image FadeInOut;

    public List<GameObject> ShapeList = new List<GameObject>();

    void Start()
    {
        rand = Random.Range(0, ShapeList.Count);
        ShapeList[rand].SetActive(true);
        FadeInOut.GetComponent<Image>();
    }

    public void Update()
    {

    }

    public void Shape_Click(int shape)
    {
        if (rand == shape)
        {
            StartCoroutine(Click());
        }
    }

    #region 버튼 클릭
    public IEnumerator Click()
    {
        // 페이드인아웃
        FadeInOut.DOFade(1, 0.8f);
        yield return new WaitForSeconds(1f);
        ShapeList[rand].SetActive(false);
        clear[rand] = true;
        List<bool> clearcheak = new List<bool>();
        for (int i = 0; i < 3; i++)
        {
            if (clear[i] != true)
            {
                clearcheak.Add(true);
            }
        }
        
        if (clearcheak.Count == 0)
        {
            FadeInOut.DOFade(0, 0.8f);
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            NextStage.DOAnchorPosY(50, 1f).SetEase(Ease.OutBounce);
            yield break;
        }
        do
        {
            rand = Random.Range(0, ShapeList.Count);
        }
        while (clear[rand] == true);
        ShapeList[rand].SetActive(true);
        FadeInOut.raycastTarget = true;
        FadeInOut.DOFade(0, 0.8f);
        FadeInOut.raycastTarget = false;
    }
    #endregion
}
