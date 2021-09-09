using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPower : MonoBehaviour
{
    [SerializeField]
    protected int Pret;
    [SerializeField]
    protected float couldown;

    public virtual void DoSomething()
    {

        Debug.Log("SuperPutere Folosita");

    }

}
