using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] private float _speed;


    private void Update()
    {
        transform.position += new Vector3(0, 0,_speed * Time.deltaTime);
    }
}
