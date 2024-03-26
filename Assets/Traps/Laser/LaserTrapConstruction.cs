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

public class LaserTrapConstruction : MonoBehaviour
{
    [SerializeField] private Transform laserEnd1;
    [SerializeField] private Transform laserEnd2;
    [SerializeField] private CapsuleCollider laserCollider;
    [SerializeField] private Material laserMaterial;
    private LineRenderer laserBeam;
    private Vector3[] laserEndPositions = new Vector3[2];


    private void OnEnable()
    {
        //Adding line renderer as laser beam
        laserBeam = gameObject.AddComponent<LineRenderer>();
        laserBeam.material = laserMaterial;
        laserBeam.startWidth = 0.1f;
        laserBeam.endWidth = 0.1f;
        
        UpdateCollision();
        
        //Placing laser beam to line up with laser ends
        laserBeam.SetPositions(laserEndPositions);
        laserBeam.enabled = true;
        
    }

    public void UpdateCollision()
    {
        laserEndPositions[0] = laserEnd1.position;
        laserEndPositions[1] = laserEnd2.position;
        //Adjusting collider to match width
        laserCollider.height = (Math.Abs(laserEnd1.localPosition.x) * 10f) - 0.7f;
    }
    public void SetLaserEnds(float width)
    {
        Vector3 newPosition = new Vector3(width * 0.5f, 0, 0);
        laserEnd1.localPosition = newPosition;
        laserEnd2.localPosition = new Vector3(-1 * newPosition.x, newPosition.y, newPosition.z);
    }

}
