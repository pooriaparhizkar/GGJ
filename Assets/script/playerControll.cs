using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerControll : MonoBehaviour ,IPointerClickHandler
{
    public static bool isBlack;
    public GameObject blackBG;
    public GameObject whiteBG;
    public GameObject mainPage;
    public GameObject deathMenu;

    private void Start()
    {
        isBlack = true;

    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            isBlack = !isBlack;
            if (isBlack)
            {
                blackBG.SetActive(true);
                whiteBG.SetActive(false);
            }
            else
            {
                blackBG.SetActive(false);
                whiteBG.SetActive(true);
            }
        }
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger");
        if (other.gameObject.CompareTag($"E1") || other.gameObject.CompareTag($"E2"))
        {
            mainPage.SetActive(false);
            deathMenu.SetActive(true);
        }
    }


}