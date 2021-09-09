using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class PlayerCombat : MonoBehaviour
{
    public Animator anim;
    public Camera camera;
    public float RazaCursor = 5f;
    public AudioSource sursa;


    private void Start()
    {
        anim.keepAnimatorControllerStateOnDisable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            Vector3 pos = camera.ScreenToWorldPoint(Input.mousePosition);
            Collider2D c = Physics2D.OverlapCircle(pos, RazaCursor);
            
            if(c != null && c.tag == "Enemy")
            {
                EnemyController controllerE = c.gameObject.GetComponent<EnemyController>();
               
               
                controllerE.EnemyTakeDamage(PlayerInstance.Instance.controler.ReturnDamage());
                sursa.Play();

     
                    anim.SetTrigger("Hit");
                
            }

        }
    }



    private void OnDrawGizmosSelected()
    {
        Vector3 pos = camera.ScreenToWorldPoint(Input.mousePosition);
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(pos, RazaCursor);
    }
}
