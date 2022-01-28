using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerControll : MonoBehaviour, IPointerClickHandler
{
    public static bool isBlack;
    public GameObject blackBG;
    public GameObject whiteBG;
    public GameObject mainPage;
    public GameObject deathMenu;
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
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

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector2(3 * Time.deltaTime, 0));
                anim.SetBool("isRunning", true);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector2(0, -3 * Time.deltaTime));
                anim.SetBool("isRunning", true);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector2(-3 * Time.deltaTime, 0));
                anim.SetBool("isRunning", true);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector2(0, 3 * Time.deltaTime));
                anim.SetBool("isRunning", true);
            }
        }

        else
        {
            anim.SetBool("isRunning", false);
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