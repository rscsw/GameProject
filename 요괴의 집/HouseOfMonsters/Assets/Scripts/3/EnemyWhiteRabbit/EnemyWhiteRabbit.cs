using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWhiteRabbit : CharactorStat
{
    public override void InitStat()
    {
        named = "하얀 토끼";
        type = "토끼";
        _hp = 500;
        hp = 500;
        _atk = 25;
        atk = 25;
        _def = 10;
        def = 10;
        _spd = 15;
        spd = 15;
        isMyTurn = false;
        isSkilled = false;
        coolDownOne = false;
        coolDownTwo = false;
    }

    void Update()
    {
        
    }
}
