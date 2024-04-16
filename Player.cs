using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public string normalAtt;
    public string skillAtt;
    private void Start()
    {
        NormalAttack();
        Skill();
    }

    public virtual void NormalAttack()
    {
        normalAtt = "Player Attacked";
    }

    public virtual void Skill()
    {
        skillAtt = "Player Skill";
    }

    public virtual void player()
    {
        GameManager.instance.normalAtt.text = normalAtt;
        GameManager.instance.skillAtt.text = skillAtt;
        GameManager.instance.name.text = "Player";
    }


}
