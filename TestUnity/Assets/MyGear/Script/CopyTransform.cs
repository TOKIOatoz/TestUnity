using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyTransform : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject1 = default;
    private Vector3 thisPosition = default;
    
    void Start()
    {
        
    }

    void Update()
    {
        thisPosition.x = gameObject1.transform.localPosition.x;
        thisPosition.y = gameObject1.transform.localPosition.y;
        thisPosition.z = gameObject1.transform.localPosition.z;
        this.transform.localPosition = thisPosition;
        this.transform.localRotation = gameObject1.transform.localRotation;
    }
}
