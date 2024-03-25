using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BobbingAnim : MonoBehaviour
{
    private Transform thisTransform;

    private float rate = 3f;

    private float distance = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        thisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thisPosition = thisTransform.position;
        float offset = (Mathf.Sin(Time.time * rate) * distance) + thisPosition.y;
        thisTransform.localPosition = new Vector3(thisPosition.x, offset, thisPosition.z);
    }
}
