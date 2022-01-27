using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class PlayerAimWeapon : MonoBehaviour
{
    private Transform aimTransform;

    private void Awake()
    {
        aimTransform = transform.Find("Aim");
    }

    private void Update()
    {
        ut
        UtilsClass.getmouseWorldPosition()
    }

    public static Vector3 GetmouseWorldPosition()
    {
        Vector3 vec = GetmouseWorldPositionwithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    public static Vector3 GetmouseWorldPosition()
    {
        return GetmouseWorldPositionwithz(Input.mousePosition,Camera.main)

    }
}
