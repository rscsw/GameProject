using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWhiteRabbitAI : MonoBehaviour
{
    public EnemyWhiteRabbit whiteRabbit;
    //공격자 

    public CharJenny jenny;
    public CharGukhwa gukhwa;
    //피격자

    public EnemyWhiteRabbitSkillOne skillOne;
    public EnemyWhiteRabbitSkillTwo skillTwo;
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

        if(whiteRabbit.isMyTurn && whiteRabbit.hp <= 0)
        {
            gm.currentState = GameState.PinkRabbitTurn;
        }
    
        //공격
        if(whiteRabbit.isMyTurn && whiteRabbit.hp > 0)
        {
            if(randomAtk == 0)
            {
                AttackJennyOne();
                gm.currentState = GameState.PinkRabbitTurn;
            }
            if(randomAtk == 1 && !skillTwo.init.isCooled)
            {
                AttackJennyTwo();
                gm.currentState = GameState.PinkRabbitTurn;
            }
            else if(randomAtk == 1 && skillTwo.init.isCooled)
            {
                AttackJennyTwo();
                gm.currentState = GameState.PinkRabbitTurn;
            }
            if(randomAtk == 2)
            {
                AttackGukhwaOne();
                gm.currentState = GameState.PinkRabbitTurn;
            }
            if(randomAtk == 3 && !skillTwo.init.isCooled)
            {
                AttackGukhwaTwo();
                gm.currentState = GameState.PinkRabbitTurn;
            }
            else if(randomAtk == 3 && skillTwo.init.isCooled)
            {
                AttackGukhwaOne();
                gm.currentState = GameState.PinkRabbitTurn;
            }
        }
        
    }

    public void AttackJennyOne()
    {
        Debug.Log("하얀 토끼 제니 공격1");
        transform.Translate(jennyPosition * 1.5f * Time.deltaTime);
        skillOne.AttackJennyOne();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }

    public void AttackJennyTwo()
    {
        Debug.Log("하얀 토끼 제니 공격2");
        transform.Translate(jennyPosition * 1.5f * Time.deltaTime);
        skillTwo.AttackJennyTwo();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }

    public void AttackGukhwaOne()
    {
        Debug.Log("하얀 토끼 국화 공격1");
        transform.Translate(gukhwaPosition * 1.5f * Time.deltaTime);
        skillOne.AttackGukhwaOne();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }

    public void AttackGukhwaTwo()
    {
        Debug.Log("하얀 토끼 국화 공격2");
        transform.Translate(gukhwaPosition * 1.5f * Time.deltaTime);
        skillTwo.AttackGukhwaTwo();
        transform.Translate(resetPosition * 1.5f * Time.deltaTime);
    }
}
