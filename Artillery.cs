using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artillery : Archer
{
    public string archerClass = "Artillery";
    private void Start()
    {
        NormalAttack();
        Skill();
    }
    public override void NormalAttack()
    {
        normalAtt = "Normal Bullet";
    }

    public override void Skill()
    {
        skillAtt = "Special Bullet";
    }

    public virtual void artillery()
    {
        GameManager.instance.normalAtt.text = normalAtt;
        GameManager.instance.skillAtt.text = skillAtt;
        GameManager.instance.name.text = "Artillery";
    }
}
