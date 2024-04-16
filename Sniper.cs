using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Archer
{
    public string archerClass = "Sniper";
    private void Start()
    {
        NormalAttack();
        Skill();
    }
    public override void NormalAttack()
    {
        normalAtt = "Body Shot";
    }

    public override void Skill()
    {
        skillAtt = "360 No Scope";
    }

    public virtual void sniper()
    {
        GameManager.instance.normalAtt.text = normalAtt;
        GameManager.instance.skillAtt.text = skillAtt;
        GameManager.instance.name.text = "Sniper";
    }
}
