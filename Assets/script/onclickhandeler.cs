using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Threading.Tasks;

public class onclickhandeler : MonoBehaviour,IPointerClickHandler
{
    public GameObject bullet;
    public GameObject player;
    public GameObject parent;

    public async void OnPointerClick(PointerEventData eventData)
    {
        GameObject go;
        go = Instantiate(bullet);
        go.transform.position = new Vector3(player.transform.position.x+0.7f,player.transform.position.y+0.1f,player.transform.position.z);
        go.transform.SetParent(parent.transform );
        go.transform.localScale = new Vector3(3, 1, 0);
        Vector3 temp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        go.transform.DOMove(temp, 0.5f);
        await Task.Delay(500);
        Destroy(go);

    }
}
