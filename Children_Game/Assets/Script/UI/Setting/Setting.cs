using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Setting : MonoBehaviour
{
    public RectTransform Setting_Btn;
    public RectTransform Setting_Window;
    public float Setting_Num;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Setting_Dot()
    {
        if (Setting_Num == 0)
        {
            Setting_Num += 1;
            //Setting_Btn.DOAnchorPosY(-508, 1f).SetEase(Ease.InOutExpo);
            Setting_Window.DOAnchorPosY(61, 1f).SetEase(Ease.InOutExpo);
        }

        else if (Setting_Num == 1)
        {
            Setting_Num -= 1;
            //Setting_Btn.DOAnchorPosY(522, 1f).SetEase(Ease.InOutExpo);
            Setting_Window.DOAnchorPosY(1031, 1f).SetEase(Ease.InOutExpo);
        }
    }
}
