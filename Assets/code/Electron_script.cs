using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Electron_script : MonoBehaviour
{
    public GameObject pivotobject;
    public float speed;
    public float lockPos;




    private void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(pivotobject.transform.position, Vector3.forward, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, lockPos, lockPos);

    }
}
