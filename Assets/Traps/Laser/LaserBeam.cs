using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class LaserBeam : MonoBehaviour
{
    public void PowerDown()
    {
        if (TryGetComponent(out LineRenderer beam))
        {
            GradientAlphaKey[] newAlphaKey = new GradientAlphaKey[beam.colorGradient.alphaKeys.Length];
            for( int key = 0; key < newAlphaKey.Length; key++)
            {
                newAlphaKey[key] = new GradientAlphaKey(0.0f, 0.0f);
            }
            beam.colorGradient.SetKeys(beam.colorGradient.colorKeys,newAlphaKey);
            Destroy(beam);
        }
        gameObject.SetActive(false);
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
