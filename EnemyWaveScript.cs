using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyWaveScript : MonoBehaviour
{
   public Transform transform;
    public GameObject canvas;
    public GameObject CrossHair;
    public SuperpowerMechanic mechanic;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0 && PlayerInstance.Instance.controler.PlayerIsDead == false)
        {
           
            canvas.SetActive(true);
            Cursor.visible = true;
            CrossHair.SetActive(false);
            mechanic.enabled = false;
            Destroy(gameObject);
            
        }
    }
}
