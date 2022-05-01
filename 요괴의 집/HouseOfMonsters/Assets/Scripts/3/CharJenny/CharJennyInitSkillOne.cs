using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJennyInitSkillOne : SkillClass
{
    public override void InitSkill()
    {
        skillName = "고대의 영물";
        skillInfo = "날카로운 발톱으로 적을 공격합니다.";
        cooltime = 0;
        _cooltime = 0;
        isCooled = false;
        isSelceted = false;
    }
}
