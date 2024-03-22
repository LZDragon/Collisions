//////////////////////////////////////////////
//Assignment/Lab/Project: Collisions
//Name: Eliza Majernik
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 03/25/2024
/////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;

    public void BindToPlayer(GameObject player)
    {
        Debug.Log("Binding GameUI");
        HealthComponent playerHealthComponent = null;
        if (!player.TryGetComponent(out playerHealthComponent))
        {
            Debug.LogError("GameUI tried to bind to player but player gameobject is missing HealthComponent");
            return;
        }
        playerHealthComponent.HandleHealthUpdated += OnPlayerHealthUpdated;
        Debug.Log("GameUI bound to player");
        InitializeHeathBar(playerHealthComponent.Health);
    }

    private void OnPlayerHealthUpdated(float newHealth)
    {
        healthBar.value = newHealth;
    }

    public int Score => score;

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText(score.ToString());
    }

    void UpdateScoreText(string value)
    {
        scoreText.text = value;
    }

    public void InitializeHeathBar(float maxHealth)
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = maxHealth;
    }
}
