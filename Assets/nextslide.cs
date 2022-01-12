using Lean.Gui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextslide : MonoBehaviour
{
   

    public LeanToggle[] slides;
    int slideindex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {
        slideindex++;
        if(slideindex>slides.Length-1)
        {
            slideindex = slides.Length - 1;
        }

        slides[slideindex].TurnOn();
    }
}
