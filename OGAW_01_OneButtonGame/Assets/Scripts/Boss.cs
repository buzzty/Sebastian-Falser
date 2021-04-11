using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private bool isAlive = true;
    [SerializeField] private TextMeshProUGUI HealthText;
    [SerializeField] private Sprite sadBernd;
    [SerializeField] private SpriteRenderer spriteRenderer;
    

    private void Start()
    {
        GameEvents.current.ButtonPressed += Damage;
        health = 100;
    }

    private void Damage()
    {
        health -= 1;
        transform.DOShakePosition(0.5f, 1.5f, 12, 90, false, true);
    }
    
    private void Update()
    {
        if (health <= 49)
        {
            spriteRenderer.sprite = sadBernd;
        }

        if (health <= 0)
        {
            health = 0;
        }

        HealthText.text = "Health = " + health;
    }
}
