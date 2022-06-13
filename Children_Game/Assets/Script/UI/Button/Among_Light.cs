using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class Among_Light : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image AmongBtn_Light;


    public void OnPointerEnter(PointerEventData eventData)
    {
        AmongBtn_Light.DOFade(1, 0.8f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        AmongBtn_Light.DOFade(0, 0.8f);
    }
}
