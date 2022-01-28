using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        Debug.Log(rotation);
        transform.rotation = rotation;

    }
}
