using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJennyInitSkillThree : SkillClass
{
    public override void InitSkill()
    {
        skillName = "영생의 기적";
        skillInfo = "매 턴이 시작할 때마다 체력을 10 회복합니다. (패시브 스킬)";
        cooltime = 0;
        _cooltime = 0;
        isCooled = false;
        isSelceted = false;
    }
}
