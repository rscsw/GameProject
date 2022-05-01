using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharJennySkillThree : SkillClass
{
    public GameObject skillPanel;
    public Text skillNameText, skillInfoText;

    public CharJenny jenny;
    public CharJennyInitSkillThree init;
    //공격자

    Vector2 resetPosition;
    //카드 원위치

    void Start()
    {
        resetPosition = transform.position;
    }

    void Update()
    {
        transform.position = resetPosition;
        if(jenny.isMyTurn && jenny.coolDownThree)
        {
            jenny.hp += 10;
            jenny.coolDownThree = false;
        }
    }

    private void OnMouseEnter()
    {
        skillPanel.SetActive(true);
        skillNameText.text = init.skillName;
        skillInfoText.text = init.skillInfo;
    }

    private void OnMouseExit()
    {
        skillPanel.SetActive(false);
    }
}
