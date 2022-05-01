using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWhiteRabbitInitSkillTwo : SkillClass
{
    public override void InitSkill()
    {
        skillName = "토끼의 눈빛";
        cooltime = 0;
        _cooltime = 2;
        skillInfo = "초롱초롱한 눈빛으로 적을 방심하게 만든 틈을 타 공격합니다. (쿨타임 "+_cooltime+"턴)";
        isCooled = false;
        isSelceted = false;
    }
}
