using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerControll : MonoBehaviour ,IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            
            transform.Translate(new Vector2(3*Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0,-3*Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-3*Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0,3*Time.deltaTime));
        }

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(eventData);
    }
}