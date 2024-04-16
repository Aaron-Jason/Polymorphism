using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator : Barbarian
{
    public string barbarianClass = "Gladiator";
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
        skillAtt = "Special Skill Slash";
    }
    public virtual void gladiator()
    {
        GameManager.instance.normalAtt.text = normalAtt;
        GameManager.instance.skillAtt.text = skillAtt;
        GameManager.instance.name.text = "Gladiator";
    }
}
