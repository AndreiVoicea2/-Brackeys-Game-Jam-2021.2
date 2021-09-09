using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayInteractable : MonoBehaviour
{
    Button buton;
    public float delay;
    private void Start()
    {
        buton = GetComponent<Button>();
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        buton.interactable = false;

        yield return new WaitForSeconds(delay);

        buton.interactable = true;
        



    }

}
