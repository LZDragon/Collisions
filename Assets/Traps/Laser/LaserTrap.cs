using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField] private float trapDamageAmount;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<HealthComponent>(out HealthComponent otherHealth) )
        {
            otherHealth.TakeDamage(trapDamageAmount);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
