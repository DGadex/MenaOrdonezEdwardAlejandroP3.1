using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLimits : MonoBehaviour
{


    private Transform theTransform = null;

    //Límites de mapa

    public Vector2 horizontalRange = Vector2.zero;
    public Vector2 verticalRange = Vector2.zero;

    void Awake()
    {
        theTransform = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        theTransform.position = new Vector3(
            Mathf.Clamp(theTransform.position.x, horizontalRange.x, horizontalRange.y),
            theTransform.position.y,
            Mathf.Clamp(theTransform.position.z, verticalRange.x, verticalRange.y));

    }
}
