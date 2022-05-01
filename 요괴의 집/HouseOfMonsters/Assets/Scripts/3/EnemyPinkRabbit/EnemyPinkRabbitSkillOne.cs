using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPinkRabbitSkillOne : SkillClass
{
    public EnemyPinkRabbit pinkRabbit;
    public EnemyPinkRabbitInitSkillOne init;
    //공격자

    public CharJenny jenny;
    public CharGukhwa gukhwa;
    //피격자

    public void AttackJennyOne()
    {
        jenny.hp -= pinkRabbit.atk - jenny.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        pinkRabbit.isSkilled = true;
    }

    public void AttackGukhwaOne()
    {
        gukhwa.hp -= pinkRabbit.atk - gukhwa.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        pinkRabbit.isSkilled = true;
    }
}
