using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAreaComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _elementsIn;

    [SerializeField]
    private GameObject[] _elementsOut;

    private bool _in;

    private bool _canSwitch;

    // Start is called before the first frame update
    void Start()
    {
        _canSwitch = true;
        _in = false;
        DoSwitch();
    }

    private void DoSwitch()
    {
        foreach(GameObject element in _elementsIn)
        {
            element.SetActive(_in);
        }

        foreach (GameObject element in _elementsOut)
        {
            element.SetActive(!_in);
        }
    }

    public void Switch(bool value)
    {
        if (!_canSwitch)
            return;

        _in = value;
        _canSwitch = false;
        DoSwitch();
    }

    public void CanSwitchAgain()
    {
        _canSwitch = true;
    }
}
