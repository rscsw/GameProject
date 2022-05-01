using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWhiteRabbitSkillOne : SkillClass
{
    public EnemyWhiteRabbit whiteRabbit;
    public EnemyWhiteRabbitInitSkillOne init;
    //공격자

    public CharJenny jenny;
    public CharGukhwa gukhwa;
    //피격자

    public void AttackJennyOne()
    {
        jenny.hp -= whiteRabbit.atk - jenny.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        whiteRabbit.isSkilled = true;
    }

    public void AttackGukhwaOne()
    {
        gukhwa.hp -= whiteRabbit.atk - gukhwa.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        whiteRabbit.isSkilled = true;
    }
}
