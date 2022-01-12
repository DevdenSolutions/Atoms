using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public GameObject Atom;
    public float speed;


    private void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(Atom.transform.position, Vector3.forward, speed * Time.deltaTime);
    }
}
