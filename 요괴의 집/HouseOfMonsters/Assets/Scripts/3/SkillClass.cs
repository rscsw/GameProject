using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillClass : MonoBehaviour
{
    public string skillName, skillInfo;
    public int cooltime, _cooltime;
    public bool isCooled, isSelceted;

    void Start()
    {
        InitSkill();
    }

    public virtual void InitSkill() { }
    //스킬 변수를 스탯을 설정하는 가상 함수
}
