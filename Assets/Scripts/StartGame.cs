using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject[] objects = new GameObject[3];
    private GameObject instance;
    private float _speed = 100f;
    private Rigidbody _rb;
    private Vector3 _dir;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _dir = new Vector3(Random.Range(-13f, 13f),1, Random.Range(-13f, 13f));
            Vector3 pos = new Vector3(Random.Range(-13f, 13f),1f, Random.Range(-13f, 13f));
            instance = Instantiate(objects[Random.Range(0, 3)], pos,  Quaternion.identity);
            instance.GetComponent<Rigidbody>().velocity = _dir * _speed * Time.deltaTime;
        }
    }
}
