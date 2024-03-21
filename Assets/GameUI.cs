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

    public void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }
}
