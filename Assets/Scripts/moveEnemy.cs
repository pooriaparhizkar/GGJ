using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class moveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 delta;

    public void setup(GameObject player2)
    {
        player = player2;
        delta = transform.position - player2.transform.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOMove(player.transform.position, 5f);
    }
}
