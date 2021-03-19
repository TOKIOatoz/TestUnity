using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelRotation : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject1 = default;
    void Start()
    {
        
    }
    void Update()
    {
        this.transform.localRotation = Quaternion.Inverse(gameObject1.transform.localRotation);
    }
}
