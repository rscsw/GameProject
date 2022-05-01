using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPinkRabbit : CharactorStat
{
    public override void InitStat()
    {
        named = "분홍 토끼";
        type = "토끼";
        _hp = 500;
        hp = 500;
        _atk = 25;
        atk = 25;
        _def = 10;
        def = 10;
        _spd = 10;
        spd = 10;
        isMyTurn = false;
        isSkilled = false;
    }

    void Update()
    {
        
    }
}
