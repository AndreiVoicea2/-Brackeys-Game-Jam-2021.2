using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerShield : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {

            EnemyController controler = collision.GetComponentInParent<EnemyController>();
            controler.deathdelegate();

        } 
    }
}
