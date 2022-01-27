using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myEnemyHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    public GameObject enemySpawArea;
    public float timerMaxTime;
    private float currentTimerValue;
    private bool gameStatus;
    public float minX;
    public float maxX;
    public GameObject player;
    void Start()
    {
        gameStatus = true;
        currentTimerValue = timerMaxTime;
    }
    public void changeInstanciateState(bool status)
    {
        gameStatus = status;
    }


    // Update is called once per frame
    void Update()
    {
        if (gameStatus)
        {
            if (currentTimerValue > 0)
            {
                currentTimerValue -= Time.deltaTime;
            }
            else
            {
                GameObject go;
                go = Instantiate(enemies[Random.Range(0, 2)]);
                go.transform.position = new Vector3(GetRandomPrefabInitialX(), enemySpawArea.transform.position.y,
                    enemySpawArea.transform.position.z);
                // enemySpawArea.transform.position;
                go.transform.SetParent(gameObject.transform);
                go.transform.localScale = new Vector3(1, 1, 1);
                go.GetComponent<moveEnemy>().setup(player);

                // reset timer
                currentTimerValue = timerMaxTime;
            }
        }
        else
        {
            Debug.Log("Injaaas");
        }
    }
    float GetRandomPrefabInitialX()
    {
        return Random.Range(minX, maxX);
    }
}