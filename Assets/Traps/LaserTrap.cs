using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField] private GameObject laserEnd1;
    [SerializeField] private GameObject laserEnd2;
    [SerializeField] private Material laserMaterial;
    private LineRenderer laserBeam;
    private Vector3[] laserEndPositions = new Vector3[2];
    private void OnEnable()
    {
        laserBeam = gameObject.AddComponent<LineRenderer>();
        laserBeam.material = laserMaterial;
        laserBeam.startWidth = 0.1f;
        laserBeam.endWidth = 0.1f;
        laserEndPositions[0] = laserEnd1.transform.position;
        laserEndPositions[1] = laserEnd2.transform.position;
        laserBeam.SetPositions(laserEndPositions);
        laserBeam.enabled = true;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
