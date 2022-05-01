using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWhiteRabbitInitSkillOne : SkillClass
{
    public override void InitSkill()
    {
        skillName = "토끼의 눈빛";
        cooltime = 0;
        _cooltime = 0;
        skillInfo = "높게 뛰어올라 적에게 달려들어 공격합니다.";
        isCooled = false;
        isSelceted = false;
    }
}
