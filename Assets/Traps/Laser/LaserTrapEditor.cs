using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof (LaserTrap))]
public class LaserTrapEditor : Editor
{
    [SerializeField] private VisualTreeAsset m_LaserInspectorXML;
    public override VisualElement CreateInspectorGUI()
    {
        VisualElement laserTrapInspector = new VisualElement();
        laserTrapInspector.Add(new Label("Laser Trap Creator"));
        m_LaserInspectorXML.CloneTree(laserTrapInspector);
        return laserTrapInspector;
    }


}
