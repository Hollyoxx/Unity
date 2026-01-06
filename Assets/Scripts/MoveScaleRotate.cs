using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScaleRotate : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Translate(_movementDirection);
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
        transform.Rotate(_rotation, _rotationSpeed);
    }
}