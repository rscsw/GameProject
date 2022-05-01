using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject[] hpSprites = new GameObject[9];
    public GameObject bossIdle;
    public GameObject bossDie;
    public GameObject bossExplosion;
    public int hp;
    private bool isActive = false;
    private int speed = 2;
    private float move;

    void Start()
    {
        hp = 9;
        bossDie.SetActive(false);
        bossExplosion.SetActive(false);
    }

    void Update()
    {
        if (gameObject.transform.position.y >= 3)
            move = 0.5f;
        else if (gameObject.transform.position.y <= 2.5)
            move = -0.5f;

        gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime * move);

        switch (hp)
        {
            case 8:
                hpSprites[8].SetActive(false);
                break;
            case 7:
                hpSprites[7].SetActive(false);
                break;
            case 6:
                hpSprites[6].SetActive(false);
                break;
            case 5:
                hpSprites[5].SetActive(false);
                break;
            case 4:
                hpSprites[4].SetActive(false);
                break;
            case 3:
                hpSprites[3].SetActive(false);
                break;
            case 2:
                hpSprites[2].SetActive(false);
                break;
            case 1:
                hpSprites[1].SetActive(false);
                break;
            case 0:
                hpSprites[0].SetActive(false);
                break;
        }

        if (hp <= 0)
        {
            bossIdle.SetActive(false);
            bossDie.SetActive(true);
            if (!isActive)
            {
                bossExplosion.SetActive(true);
                isActive = true;
            }
            else
            {
                Destroy(bossExplosion, 2.583f);
            }
        }
    }
}
