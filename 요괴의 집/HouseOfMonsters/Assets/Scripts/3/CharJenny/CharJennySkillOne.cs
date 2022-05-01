using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharJennySkillOne : SkillClass
{
    public GameObject skillPanel;
    public Text skillNameText, skillInfoText;

    public CharJenny jenny;
    public CharJennyInitSkillOne init;
    //공격자

    public EnemyWhiteRabbit whiteRabbit;
    public EnemyPinkRabbit pinkRabbit;
    //피격자

    Vector2 resetPosition;
    //카드 원위치

    void Start()
    {
        resetPosition = transform.position;
    }

    void Update()
    {
        if(init.isSelceted)
        {
            skillPanel.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        skillPanel.SetActive(true);
        skillNameText.text = init.skillName;
        skillInfoText.text = init.skillInfo;
    }

    private void OnMouseOver()
    {
        if(!init.isSelceted)
        {
            skillPanel.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if(jenny.isMyTurn)
        {
            init.isSelceted = true;
        }
    }

    private void OnMouseDrag()
    {
        if(jenny.isMyTurn && init.isSelceted)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 gameObjectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = gameObjectPosition;
        }
        if(!jenny.isMyTurn || !init.isSelceted)
        {
            transform.position = resetPosition;
        }
    }

    private void OnMouseUp()
    {
        transform.position = resetPosition;
        init.isSelceted = false;
    }

    private void OnMouseExit()
    {
        skillPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WhiteRabbit"))
        {
            if(whiteRabbit.hp > 0)
            {
                whiteRabbit.hp -= jenny.atk - whiteRabbit.def;
                init.isSelceted = false;
                jenny.isSkilled = true;
            }
        }
        if (other.CompareTag("PinkRabbit"))
        {
            if(pinkRabbit.hp > 0)
            {
                pinkRabbit.hp -= jenny.atk - pinkRabbit.def;
                init.isSelceted = false;
                jenny.isSkilled = true;
            }
        }
    }
}
