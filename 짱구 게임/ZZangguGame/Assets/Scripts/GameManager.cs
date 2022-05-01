using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ship, boss, item, missile;
    public Boss bossScript;
    private Vector3 bossPos;
    private float randomY;

    void Start()
    {
        bossPos = boss.transform.position;
        randomY = Random.Range(-3, 3);
        InvokeRepeating("Missile", 3, 0.5f);
        InvokeRepeating("Item", 3, 1);
    }
    void Missile()
    {
        Instantiate(missile, bossPos, Quaternion.identity);
    }

    void Item()
    {
        Instantiate(item, new Vector3(10, Random.Range(-3, 3), -3), Quaternion.identity);
    }

    void Update()
    {
        if(bossScript.hp <= 0)
        {
            CancelInvoke("Missile");
            CancelInvoke("Item");
        }
    }
}
