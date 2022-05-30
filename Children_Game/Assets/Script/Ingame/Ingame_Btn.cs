using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Ingame_Btn : MonoBehaviour
{
    [Header("정답 갯수")]
    public float Clear;

    [Header("도형 버튼")]
    public Button Circle_Btn;
    public Button Rectangle_Btn;
    public Button Triangle_Btn;

    [Header("페이드인아웃")]
    public Image FadeInOut;



    void Start()
    {
        Clear = 0f;

        Circle_Btn.GetComponent<Button>();
        Triangle_Btn.GetComponent<Button>();
        Triangle_Btn.GetComponent<Button>();

        FadeInOut.GetComponent<Image>();
    }

    void Update()
    {
        
    }

    public void CirCle()
    {
        if (Clear == 1)
        {
            StartCoroutine(Fade());
        }
    }

    public void Rectangle()
    {
        if (Clear == 0)
        {
            StartCoroutine(Fade());
        }
    }

    public void Triangle()
    {
        if (Clear == 2)
        {
            StartCoroutine(Fade());
        }
    }

    public IEnumerator Fade()
    {
        // 페이드인아웃
        FadeInOut.raycastTarget = true;
        FadeInOut.DOFade(1, 0.8f);
        yield return new WaitForSeconds(1f);
        FadeInOut.DOFade(0, 0.8f);
        FadeInOut.raycastTarget = false;

        Clear += 1f;
        if (Clear == 1)
        {
            GameObject.Find("Shape").transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("Shape").transform.GetChild(1).gameObject.SetActive(true);
        }

        else if (Clear == 2)
        {
            GameObject.Find("Shape").transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("Shape").transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
