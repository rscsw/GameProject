using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPinkRabbitAI : MonoBehaviour
{
    public EnemyPinkRabbit pinkRabbit;
    //공격자 

    public CharJenny jenny;
    public CharGukhwa gukhwa;
    //피격자

    public EnemyPinkRabbitSkillOne skillOne;
    public EnemyPinkRabbitSkillTwo skillTwo;
    //스킬

    public GameObject jennyObj;
    public GameObject gukhwaObj;
    //피격자 위치

    public GameManager gm;
    //게임 매니저 (강제 스테이트 변경)

    int randomAtk;
    Vector2 resetPosition;
    Vector2 jennyPosition;
    Vector2 gukhwaPosition;

    void Start()
    {
        resetPosition = transform.position;
        jennyPosition = jennyObj.transform.position;
        gukhwaPosition = gukhwaObj.transform.position;
    }

    void Update()
    {
        randomAtk = Random.Range(0, 4);

        if(pinkRabbit.isMyTurn && pinkRabbit.hp <= 0)
        {
            gm.currentState = GameState.JennyTurn;
        }

        if(pinkRabbit.isMyTurn && pinkRabbit.hp > 0)
        {
            if(randomAtk == 0)
            {
                AttackJennyOne();
                gm.currentState = GameState.JennyTurn;
            }
            if(randomAtk == 1 && !skillTwo.init.isCooled)
            {
                AttackJennyTwo();
                gm.currentState = GameState.JennyTurn;
            }
            else if(randomAtk == 1 && skillTwo.init.isCooled)
            {
                AttackJennyOne();
                gm.currentState = GameState.JennyTurn;
            }
            if(randomAtk == 2)
            {
                AttackGukhwaOne();
                gm.currentState = GameState.JennyTurn;
            }
            if(randomAtk == 3 && !skillTwo.init.isCooled)
            {
                AttackGukhwaTwo();
                gm.currentState = GameState.JennyTurn;
            }
            else if(randomAtk == 3 && skillTwo.init.isCooled)
            {
                AttackGukhwaTwo();
                gm.currentState = GameState.JennyTurn;
            }
        }
        
    }

    public void AttackJennyOne()
    {
        Debug.Log("분홍 토끼 제니 공격1");
        transform.Translate(jennyPosition * 1.5f * Time.deltaTime);
        skillOne.AttackJennyOne();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }

    public void AttackJennyTwo()
    {
        Debug.Log("분홍 토끼 제니 공격2");
        transform.Translate(jennyPosition * 1.5f * Time.deltaTime);
        skillTwo.AttackJennyTwo();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }

    public void AttackGukhwaOne()
    {
        Debug.Log("분홍 토끼 국화 공격1");
        transform.Translate(gukhwaPosition * 1.5f * Time.deltaTime);
        skillOne.AttackGukhwaOne();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }

    public void AttackGukhwaTwo()
    {
        Debug.Log("분홍 토끼 국화 공격2");
        transform.Translate(gukhwaPosition * 1.5f * Time.deltaTime);
        skillTwo.AttackGukhwaTwo();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }
}
