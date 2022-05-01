using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGukhwaInitSkillOne : SkillClass
{
    public override void InitSkill()
    {
        skillName = "새파란 불";
        skillInfo = "새파란 불을 뿜어 적을 공격합니다.";
        cooltime = 0;
        _cooltime = 0;
        isCooled = false;
        isSelceted = false;
    }
}
