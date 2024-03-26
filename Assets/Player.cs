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
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(HealthComponent))]
public class Player : MonoBehaviour
{
    [SerializeField] private GameUI gameUI;

    private void Start()
    {
        gameUI.BindToPlayer(this.gameObject);
        GetComponent<HealthComponent>().HandleOnKilled += OnKilled;
    }

    private void OnKilled()
    {
        SceneManager.LoadScene(0);
    }
}
