using Lean.Gui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lean.Transition;

public class nextslide : MonoBehaviour
{
   

    public LeanToggle[] slides;
    public Transform listParent;
    int slideindex;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < slides.Length; i++)
        {
            int k = i;
            listParent.GetChild(k).GetComponent<Button>().onClick.AddListener(() => { ChangeSlide(k); });
        }
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

    public void Previous()
    {
        slideindex--;
        if (slideindex < 0)
        {
            slideindex = 0;
        }

        slides[slideindex].TurnOn();
    }
    public void ChangeSlide(int i)
    {
        slideindex = i;

        if (slideindex > slides.Length - 1)
        {
            slideindex = slides.Length - 1;
        }

        slides[slideindex].TurnOn();

    }

    public void ResetSlide()
    {

        slides[slideindex].TurnOff();
        transform.EventTransition(() =>
        {
            slides[slideindex].TurnOn();

        }, 0.2f);
    }
}
