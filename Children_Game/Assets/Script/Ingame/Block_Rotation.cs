using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Rotation : MonoBehaviour
{
    [Header("도형 회전 속도")]
    public float BlockRotation_Speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        Mouse_Rotation();
    }

    private void Mouse_Rotation()
    {
        if (Input.GetMouseButton(0))
        {
            float rotX = Input.GetAxis("Mouse X") * BlockRotation_Speed;
            float rotY = Input.GetAxis("Mouse Y") * BlockRotation_Speed;

            transform.Rotate(Vector3.up * -rotX + Vector3.right * rotY, Space.World);
        }

    }
}
