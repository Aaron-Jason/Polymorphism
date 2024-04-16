using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : Player
{
    public string playerClass = "Barbarian";

    private void Start()
    {
        NormalAttack();
        Skill();
    }
    public override void NormalAttack()
    {
        normalAtt = "Normal Slash";
    }

    public override void Skill()
    {
        skillAtt = "Reckless Attack";
    }

    public virtual void barbarian()
    {
        GameManager.instance.normalAtt.text = normalAtt;
        GameManager.instance.skillAtt.text = skillAtt;
        GameManager.instance.name.text = "Barbarian";
    }
}
