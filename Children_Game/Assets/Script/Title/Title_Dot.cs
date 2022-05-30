using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Title_Dot : MonoBehaviour
{
    [Header("지구")]
    public GameObject Earth;

    [Header("지구의 회전 속도")]
    public float Earth_Speed;

    [Header("구름")]
    public GameObject Clude_01;
    public GameObject Clude_02;
    public GameObject Clude_03;
    public RectTransform Clude_04;

    void Start()
    {
    }

    void Update()
    {
        Earth_Dot();
    }

    public void Earth_Dot()
    {
        Earth.transform.Rotate(Vector3.up * Time.deltaTime * Earth_Speed);
    }

    public void Clude_Dot()
    {
        StartCoroutine(Clude());
    }

    public IEnumerator Clude()
    {
        Clude_04.DOAnchorPosX(690, 1f);
        Clude_04.DOAnchorPosY(-412, 1f);
        yield return new WaitForSeconds(1.5f);
        Clude_04.DOAnchorPosX(640, 1f);
        Clude_04.DOAnchorPosY(-489, 1f);
    }
}
