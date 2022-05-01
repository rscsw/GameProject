using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJennyInitSkillTwo : SkillClass
{
    public override void InitSkill()
    {
        skillName = "포식자";
        cooltime = 0;
        _cooltime = 3;
        skillInfo = "상대를 공격하고 입힌 데미지의 10%를 회복합니다. (쿨타임 "+_cooltime+"턴)";
        isCooled = false;
        isSelceted = false;
    }
}
