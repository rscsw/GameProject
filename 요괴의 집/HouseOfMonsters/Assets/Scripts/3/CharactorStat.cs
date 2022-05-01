using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorStat : MonoBehaviour
{
    public string named, type;
    public int _hp, hp;
    public int _atk, atk;
    public int _def, def;
    public int _spd, spd;
    public bool isMyTurn, isSkilled, coolDownOne, coolDownTwo, coolDownThree;

    void Start()
    {
        InitStat();
    }

    public virtual void InitStat() { }
    //각 캐릭터마다 스탯을 설정하는 가상 함수
}
