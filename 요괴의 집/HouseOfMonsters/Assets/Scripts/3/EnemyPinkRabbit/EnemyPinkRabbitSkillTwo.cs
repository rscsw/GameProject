using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPinkRabbitSkillTwo : SkillClass
{
    public EnemyPinkRabbit pinkRabbit;
    public EnemyPinkRabbitInitSkillTwo init;
    //공격자

    public CharJenny jenny;
    public CharGukhwa gukhwa;
    //피격자

    void Update()
    {
        if(pinkRabbit.isMyTurn && init.isCooled && pinkRabbit.coolDownTwo && init.cooltime > 0)
        {
            init.cooltime--;
            pinkRabbit.coolDownTwo = false;
        }
        if(init.cooltime <= 0)
        {
            init.isCooled = false;
        }
    }

    public void AttackJennyTwo()
    {
        jenny.hp -= (pinkRabbit.atk * 2) - jenny.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        pinkRabbit.isSkilled = true;
        init.isCooled = true;
    }

    public void AttackGukhwaTwo()
    {
        gukhwa.hp -= (pinkRabbit.atk * 2) - gukhwa.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        pinkRabbit.isSkilled = true;
        init.isCooled = true;
    }
}
