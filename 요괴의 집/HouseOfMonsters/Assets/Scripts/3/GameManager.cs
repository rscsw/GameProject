using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Waiting,
    JennyTurn,
    GukhwaTurn,
    WhiteRabbitTurn,
    PinkRabbitTurn,
    Win,
    Lose
}

public class GameManager : MonoBehaviour
{
    public CharJenny jenny;
    public CharGukhwa gukhwa;
    public EnemyWhiteRabbit whiteRabbit;
    public EnemyPinkRabbit pinkRabbit;

    public GameObject skillPanel;
    public GameObject jennySkillCard;
    public GameObject gukhwaSkillCard;

    public GameObject gameStart;
    public GameObject win;
    public GameObject lose;

    public GameState currentState;

    void Start()
    {
        currentState = GameState.Waiting;
        jenny.isMyTurn = false;
        gukhwa.isMyTurn = false;
        whiteRabbit.isMyTurn = false;
        pinkRabbit.isMyTurn = false;
        jennySkillCard.SetActive(false);
        gukhwaSkillCard.SetActive(false);
        gameStart.SetActive(true);
        win.SetActive(false);
        lose.SetActive(false);
    }

    void Update()
    {
        switch (currentState)
        {
            case GameState.Waiting:
                jenny.isMyTurn = false; gukhwa.isMyTurn = false; whiteRabbit.isMyTurn = false; pinkRabbit.isMyTurn = false;
                Destroy(gameStart, 2);
                if(gameStart == null)
                {
                    currentState = GameState.JennyTurn;
                }
                break;
            case GameState.JennyTurn:
                jenny.isMyTurn = true; gukhwa.isMyTurn = false; whiteRabbit.isMyTurn = false; pinkRabbit.isMyTurn = false;
                jennySkillCard.SetActive(true);
                if(jenny.isSkilled)
                {
                    currentState = GameState.GukhwaTurn;
                    jenny.coolDownTwo = true;
                    jenny.coolDownThree = true;
                    jenny.isSkilled = false;
                    jennySkillCard.SetActive(false);
                    skillPanel.SetActive(false);
                }
                break;
            case GameState.GukhwaTurn:
                jenny.isMyTurn = false; gukhwa.isMyTurn = true; whiteRabbit.isMyTurn = false; pinkRabbit.isMyTurn = false;
                gukhwaSkillCard.SetActive(true);
                if(gukhwa.isSkilled)
                {
                    currentState = GameState.WhiteRabbitTurn;
                    gukhwa.coolDownTwo = true;
                    gukhwa.coolDownThree = true;
                    gukhwa.isSkilled = false;
                    gukhwaSkillCard.SetActive(false);
                    skillPanel.SetActive(false);
                }
                break;
            case GameState.WhiteRabbitTurn:
                jenny.isMyTurn = false; gukhwa.isMyTurn = false; whiteRabbit.isMyTurn = true; pinkRabbit.isMyTurn = false;
                if(whiteRabbit.isSkilled)
                {
                    currentState = GameState.PinkRabbitTurn;
                    whiteRabbit.isSkilled = false;
                    whiteRabbit.coolDownTwo = true;
                    skillPanel.SetActive(false);
                }
                break;
            case GameState.PinkRabbitTurn:
                jenny.isMyTurn = false; gukhwa.isMyTurn = false; whiteRabbit.isMyTurn = false; pinkRabbit.isMyTurn = true;
                if(pinkRabbit.isSkilled)
                {
                    currentState = GameState.JennyTurn;
                    pinkRabbit.coolDownTwo = true;
                    pinkRabbit.isSkilled = false;
                    skillPanel.SetActive(false);
                }
                break;
            case GameState.Win:
                jenny.isMyTurn = false; gukhwa.isMyTurn = false; whiteRabbit.isMyTurn = false; pinkRabbit.isMyTurn = false;
                win.SetActive(true);
                break;
            case GameState.Lose:
                jenny.isMyTurn = false; gukhwa.isMyTurn = false; whiteRabbit.isMyTurn = false; pinkRabbit.isMyTurn = false;
                lose.SetActive(true);
                break;
        }

        //체력 표기 관리
        if(jenny.hp > jenny._hp)
            jenny.hp = jenny._hp;
        if(jenny.hp < 0)
            jenny.hp = 0;
        if(gukhwa.hp > gukhwa._hp)
            gukhwa.hp = gukhwa._hp;
        if(gukhwa.hp < 0)
            gukhwa.hp = 0;
        if(whiteRabbit.hp > whiteRabbit._hp)
            whiteRabbit.hp = whiteRabbit._hp;
        if(whiteRabbit.hp < 0)
            whiteRabbit.hp = 0;
        if(pinkRabbit.hp > pinkRabbit._hp)
            pinkRabbit.hp = pinkRabbit._hp;
        if(pinkRabbit.hp < 0)
            pinkRabbit.hp = 0;
        
        //승패 관리
        if(whiteRabbit.hp <= 0 && pinkRabbit.hp <= 0)
        {
            currentState = GameState.Win;
        }
        if(jenny.hp <= 0 && gukhwa.hp <= 0)
        {
            currentState = GameState.Lose;
        }
    }
}
