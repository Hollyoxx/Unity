using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(_rotation, _rotationSpeed);
    }
}