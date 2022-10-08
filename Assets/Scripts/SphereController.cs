using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private Vector3 _moveDir;
    private float _speed;

    void Start()
    {
        Vector2 random = Random.insideUnitCircle.normalized;
        _moveDir = new Vector3(random.x, 1, random.y);
    }
    void Update()
    {
        transform.position += _moveDir * _speed * Time.deltaTime;
    }
}
