using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGukhwa : CharactorStat
{
    public override void InitStat()
    {
        named = "한국화";
        type = "보은섬여";
        _hp = 600;
        hp = 600;
        _atk = 50;
        atk = 50;
        _def = 10;
        def = 10;
        _spd = 45;
        spd = 45;
        isMyTurn = false;
        isSkilled = false;
        coolDownOne = false;
        coolDownTwo = false;
        coolDownThree = false;
    }
}
