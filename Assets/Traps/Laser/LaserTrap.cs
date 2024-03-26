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
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    public float m_HallWidth = 10.0f;
    public float m_HallHeight = 10.0f;
    public float m_LaserSpacing = 0.5f;
    public GameObject m_LaserPower;
    public Transform  m_LaserContainer;
    public GameObject m_LaserTrapSingle;
    public List<GameObject> lasers;


    private void OnDrawGizmosSelected()
    {
        UpdateLaserGrid();
    }
    


    public void UpdateLaserGrid()
    {
        if (m_LaserContainer.childCount > 0)
        {
            for (int i = m_LaserContainer.childCount - 1; i >= 0; i--)
            {
                DestroyImmediate(m_LaserContainer.GetChild(i).gameObject);
            }
        }
        Vector3 newPosition;
        for (float i = m_LaserSpacing * 2f; i <= m_HallHeight; i += m_LaserSpacing * 2f)
        {
            newPosition = new Vector3(0, i - (m_HallHeight* 0.5f), 0) + m_LaserContainer.position;
            GameObject newLaser = Instantiate(m_LaserTrapSingle, newPosition, quaternion.identity, m_LaserContainer);
            LaserTrapConstruction constructionScript = newLaser.GetComponent<LaserTrapConstruction>();
            constructionScript.SetLaserEnds(m_HallWidth);
            constructionScript.UpdateCollision();
            lasers.Add(newLaser);
        }

        for (float j = 0.3f; j <= m_HallWidth-0.3f; j += m_LaserSpacing * 1.5f)
        {
            newPosition = new Vector3(j - (m_HallWidth * 0.5f), 0, 0) + m_LaserContainer.position;
            Quaternion newRotation = Quaternion.Euler(0,0,90);
            GameObject newLaser = Instantiate(m_LaserTrapSingle, newPosition,newRotation, m_LaserContainer);
            LaserTrapConstruction constructionScript = newLaser.GetComponent<LaserTrapConstruction>();
            constructionScript.SetLaserEnds(m_HallHeight);
            constructionScript.UpdateCollision();
            lasers.Add(newLaser);
        }
    }

    private void Start()
    {
        m_LaserPower.GetComponent<LaserTrapPower>().Lasers = lasers;
    }
}
