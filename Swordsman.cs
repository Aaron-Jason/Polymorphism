using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Barbarian
{
    public string barbarianClass = "Swordsman";
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
        skillAtt = "PURGATORY ONIGIRI";
    }
    public virtual void swordsman()
    {
        GameManager.instance.normalAtt.text = normalAtt;
        GameManager.instance.skillAtt.text = skillAtt;
        GameManager.instance.name.text = "Swordsman";
    }
}
