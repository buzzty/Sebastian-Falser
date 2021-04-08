using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action ButtonPressed;

    public void HitBoss()
    {
        if (ButtonPressed != null)
        {
            ButtonPressed();
        }
    }

    public event Action BossDead;

    public void EndFight()
    {
        if (BossDead != null)
        {
            BossDead();
        }
    }
}
