using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(HealthComponent))]
public class LaserTrapPower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<HealthComponent>().HandleOnKilled += OnKilled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnKilled()
    {
        LaserBeam[] childrenLaserBeams = GetComponentsInChildren<LaserBeam>();
        foreach (var laserBeam in childrenLaserBeams)
        {
            laserBeam.PowerDown();
        }

    }
    
}
