using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Gui;

public class LeanOnOff : MonoBehaviour
{
    private LeanToggle anatodeLeanToggle;

    void Start()
    {
        anatodeLeanToggle = gameObject.GetComponent<LeanToggle>();
    }


    public void UIOnOff()
    {
        if (!anatodeLeanToggle.On)
        {
            anatodeLeanToggle.On = true;
        }
        else
        {
            anatodeLeanToggle.On = false;
        }
    }
}
