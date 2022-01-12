using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class tween2 : MonoBehaviour
{
    public Transform elec;
    public PathType pathsystem = PathType.CatmullRom;
    [Header("for right wire")]
    public Vector3[] pathval = new Vector3[4];
   
    
    public Tween t;
    
   
    // Start is called before the first frame update
    void Start()
    {
        t = elec.transform.DOPath(pathval, 10, pathsystem);
        t.SetEase(Ease.Linear).SetLoops(-1);




    }

    // Update is called once per frame
    void Update()
    {
       
        
           
        
      

    }
   
    
}
