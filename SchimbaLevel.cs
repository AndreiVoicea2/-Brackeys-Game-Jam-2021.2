using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchimbaLevel : MonoBehaviour
{
    public GameObject[] Levele;
    public int NrLevel = 1;
    public Animator animm;
    public void SchimbaLevelGen()
    {
        for (int i = 0; i < Levele.Length ; i++)
        {
            if (i == NrLevel - 1) Levele[i].SetActive(false);

            if (i == NrLevel)
            {
                Levele[i].SetActive(true);


            }

            if( NrLevel == 6)
            {

                StartCoroutine(delay());

            }
        }

        NrLevel++;
    }


    IEnumerator delay()
    {
        animm.SetTrigger("Start");
        yield return new WaitForSeconds(2f);
        Cursor.visible = true;
        Application.LoadLevel(2);


    }
     
}
