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

    public Camera Camera;


    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject go;
        go = Instantiate(bullet);
        go.transform.position = player.transform.position;
        // enemySpawArea.transform.position;
        go.transform.SetParent(parent.transform );
        go.transform.localScale = new Vector3(1, 1, 1);
        // Debug.Log(eventData.pressPosition);
        // Debug.Log(player.transform.position);
        Debug.Log(Input.mousePosition);
        Vector3 temp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(temp);
        // Debug.Log(player.transform.localPosition);
        Debug.Log(Input.mousePosition);
        go.transform.DOMove(temp, 0.5f);
        // go.transform.position = temp;
        //
        // Vector3 shootDirection;
        // shootDirection = Input.mousePosition;
        // shootDirection.z = 0.0f;
        // shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        // shootDirection = shootDirection-transform.position;
        //...instantiating the rocket
        // Rigidbody2D bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
        // bulletInstance.velocity = new Vector2(shootDirection.x * 0.2f, shootDirection.y * 0.2f);
        
    }
}
