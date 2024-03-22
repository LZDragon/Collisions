using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameUI gameUI;
    private void Start()
    {
        gameUI.BindToPlayer(this.gameObject);
    }
}
