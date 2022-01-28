using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;

public class bulletLogic : MonoBehaviour
{
    public GameObject blackBG;
    public GameObject whiteBG;
    public GameObject enemy;
    public GameObject particle;

    private void Start()
    {
        blackBG = GameObject.FindGameObjectWithTag("BGE1");
        whiteBG = GameObject.FindGameObjectWithTag("BGE2");
    }


    private async void OnCollisionEnter2D(Collision2D other)
    {
        //E1 : white
        //E2 : black
        if (other.gameObject.CompareTag($"E1"))
        {
            if (blackBG.activeSelf)
            {
                Destroy(gameObject);
                Instantiate(particle, transform.position, quaternion.identity);
                enemy = other.gameObject;
                enemy.GetComponent<Animator>().SetBool("isDeath", true);

                await Task.Delay(900);
                Destroy(other.gameObject);

            }

        }
        if (other.gameObject.CompareTag($"E2"))
        {
            if (whiteBG.activeSelf)
            {
                Destroy(gameObject);
                Instantiate(particle, transform.position, quaternion.identity);
                enemy = other.gameObject;
                enemy.GetComponent<Animator>().SetBool("isDeath", true);
                await Task.Delay(900);
                Destroy(other.gameObject);

            }

        }
    }
}
