using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLogic : MonoBehaviour
{
    public GameObject blackBG;
    public GameObject whiteBG;

    private void Start()
    {
        Debug.Log("Dsada");
        blackBG = GameObject.FindGameObjectWithTag("BGE1");
        whiteBG = GameObject.FindGameObjectWithTag("BGE2");
    }


    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag($"E1"))
        {
            if (blackBG.activeSelf)
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }

        }
        if (other.gameObject.CompareTag($"E2"))
        {
            if (whiteBG.activeSelf)
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }

        }
    }
}
