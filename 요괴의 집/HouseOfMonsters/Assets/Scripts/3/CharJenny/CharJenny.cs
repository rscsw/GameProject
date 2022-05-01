using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJenny : CharactorStat
{
    public override void InitStat()
    {
        named = "권제니";
        type = "십삼미호";
        _hp = 1000;
        hp = 1000;
        _atk = 40;
        atk = 40;
        _def = 20;
        def = 20;
        _spd = 50;
        spd = 50;
        isMyTurn = false;
        isSkilled = false;
        coolDownOne = false;
        coolDownTwo = false;
        coolDownThree = false;
    }
}
