using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWhiteRabbitSkillTwo : SkillClass
{
    public EnemyWhiteRabbit whiteRabbit;
    public EnemyWhiteRabbitInitSkillTwo init;
    //공격자

    public CharJenny jenny;
    public CharGukhwa gukhwa;
    //피격자

    void Update()
    {
        if(whiteRabbit.isMyTurn && init.isCooled && whiteRabbit.coolDownTwo && init.cooltime > 0)
        {
            init.cooltime--;
            whiteRabbit.coolDownTwo = false;
        }
        if(init.cooltime <= 0)
        {
            init.isCooled = false;
        }
    }

    public void AttackJennyTwo()
    {
        jenny.hp -= (whiteRabbit.atk * 2) - jenny.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        whiteRabbit.isSkilled = true;
        init.isCooled = true;
    }

    public void AttackGukhwaTwo()
    {
        gukhwa.hp -= (whiteRabbit.atk * 2) - gukhwa.def;
        init.cooltime = init._cooltime + 1;
        init.isSelceted = false;
        whiteRabbit.isSkilled = true;
        init.isCooled = true;
    }
}
