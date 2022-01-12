using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotat : MonoBehaviour
{
    public GameObject pivotobject;
    public float speed;
    public Vector3 direction;


    private void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(pivotobject.transform.position, direction , speed * Time.deltaTime);
    }
}
