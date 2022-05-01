using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGukhwaInitSkillThree : SkillClass
{
    public override void InitSkill()
    {
        skillName = "살신성인";
        cooltime = 0;
        _cooltime = 5;
        skillInfo = "적에게 강력한 일격을 가합니다. 반동으로 현재 체력의 절반이 감소합니다. (쿨타임 "+_cooltime+"턴)";
        isCooled = false;
        isSelceted = false;
    }
}
