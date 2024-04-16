using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Archer : Player
{
    public string playerClass = "Archer";

    private void Start()
    {
        NormalAttack();
        Skill();
    }
    public override void NormalAttack()
    {
        normalAtt = "Normal Arrow";
    }

    public override void Skill()
    {
        skillAtt = "Flaming Arrow";
    }

    public virtual void archer()
    {
        GameManager.instance.normalAtt.text = normalAtt;
        GameManager.instance.skillAtt.text = skillAtt;
        GameManager.instance.name.text = "Archer";
    }

}
