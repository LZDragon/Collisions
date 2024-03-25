using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        throw new NotImplementedException();
    }
}
