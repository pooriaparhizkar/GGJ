using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class onclickhandeler : MonoBehaviour,IPointerClickHandler
{
    public GameObject bullet;
    public GameObject player;
    public GameObject parent;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject go;
        go = Instantiate(bullet);
        go.transform.position = player.transform.position;
        go.transform.SetParent(parent.transform );
        go.transform.localScale = new Vector3(1, 1, 1);
        Vector3 temp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        go.transform.DOMove(temp, 0.5f);

    }
}
