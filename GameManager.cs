using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Player Info")]
    public TextMeshProUGUI normalAtt;
    public TextMeshProUGUI skillAtt;
    public TextMeshProUGUI name;

    public static GameManager instance;
    public void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

}
