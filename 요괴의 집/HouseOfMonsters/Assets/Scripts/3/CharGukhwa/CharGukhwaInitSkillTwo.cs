using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGukhwaInitSkillTwo : SkillClass
{
    public override void InitSkill()
    {
        skillName = "두꺼비 독";
        cooltime = 0;
        _cooltime = 2;
        skillInfo = "독을 뿜어 적을 공격합니다. 적의 방어를 무시합니다. (쿨타임 "+_cooltime+"턴)";
        isCooled = false;
        isSelceted = false;
    }
}
