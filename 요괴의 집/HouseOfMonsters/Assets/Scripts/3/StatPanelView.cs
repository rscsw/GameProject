using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatPanelView : MonoBehaviour
{
    public GameObject statPanel;
    public Text statPanelText;

    public CharJenny jenny;
    public CharGukhwa gukhwa;
    public EnemyWhiteRabbit whiteRabbit;
    public EnemyPinkRabbit pinkRabbit;

    private void OnMouseEnter()
    {
        statPanel.SetActive(true);
        switch(gameObject.tag)
        {
            case "Jenny":
                statPanelText.text = "이름 : " + jenny.named + 
                                     "\n종족 : " + jenny.type +
                                     "\n체력 : " + jenny.hp + "/" + jenny._hp +
                                     "\n공격력 : " + jenny._atk +
                                     "\n방어력 : " + jenny._def +
                                     "\n공격 속도 : " + jenny._spd;
                break;
            case "Gukhwa":
                statPanelText.text = "이름 : " + gukhwa.named + 
                                     "\n종족 : " + gukhwa.type +
                                     "\n체력 : " + gukhwa.hp + "/" + gukhwa._hp +
                                     "\n공격력 : " + gukhwa._atk +
                                     "\n방어력 : " + gukhwa._def +
                                     "\n공격 속도 : " + gukhwa._spd;
                break;
            case "WhiteRabbit":
                statPanelText.text = "이름 : " + whiteRabbit.named + 
                                     "\n종족 : " + whiteRabbit.type +
                                     "\n체력 : " + whiteRabbit.hp + "/" + whiteRabbit._hp +
                                     "\n공격력 : " + whiteRabbit._atk +
                                     "\n방어력 : " + whiteRabbit._def +
                                     "\n공격 속도 : " + whiteRabbit._spd;
                break;
            case "PinkRabbit":
                statPanelText.text = "이름 : " + pinkRabbit.named + 
                                     "\n종족 : " + pinkRabbit.type +
                                     "\n체력 : " + pinkRabbit.hp + "/" + pinkRabbit._hp +
                                     "\n공격력 : " + pinkRabbit._atk +
                                     "\n방어력 : " + pinkRabbit._def +
                                     "\n공격 속도 : " + pinkRabbit._spd;
                break;

        }
    }

    private void OnMouseExit()
    {
        statPanel.SetActive(false);
    }
}
