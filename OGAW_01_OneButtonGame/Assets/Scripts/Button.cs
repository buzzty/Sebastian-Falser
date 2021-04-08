using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Button : MonoBehaviour
{
    private int damage = 1;
    private bool canHit = true;

    private void Start()
    {
        GameEvents.current.BossDead += StopHit;
    }

    private void StopHit()
    {
        canHit = false;
    }

    public void Hit()
    {
        if (canHit)
        {
            GameEvents.current.HitBoss();
        }
    }
}
