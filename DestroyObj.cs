using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public float delay;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, delay);
    }
}
