using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using TMPro;


public class EnemyController : EnemyStats
{

    //La explozie se face ecranul alb

    [Header("UI Components")]
    [Space(10)]

    public Slider slider;

    [Header("Objects and Vectors")]
    [Space(10)]

    public GameObject Explosion;
    public GameObject TextPopup;
    public Transform PopUpTrans;


    public delegate void EnemyDeathDelegate();
    public EnemyDeathDelegate deathdelegate;
    
   
    void Start()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
        slider.maxValue = EnemyMaxHealth;
        slider.value = EnemyCurrentHealth;
        //
        deathdelegate += Die;
        deathdelegate += DropRewardForPlayer;
      
    }

    
    void Update()
    {
        if (EnemyCurrentHealth < 0)
        {
            EnemyCurrentHealth = 0;
            slider.value = EnemyCurrentHealth;
        }
    }

    public void EnemyTakeDamage(int damage)
    {

        EnemyCurrentHealth -= damage;

        slider.value = EnemyCurrentHealth;
        if (EnemyCurrentHealth <= 0) deathdelegate();

       

    }

    public void Die()
    {
        if(Explosion != null)
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(gameObject);
       

    }

    void DropRewardForPlayer()
    {
        PlayerInstance.Instance.controler.GetReward(EnemyDropReward);
        TextMeshPro text = TextPopup.GetComponent<TextMeshPro>();
        text.text = EnemyDropReward.ToString() + " Coins";
        Instantiate(TextPopup, PopUpTrans.transform.position, PopUpTrans.rotation);

    }

    public int ReturnDamage()
    {



        return EnemyDamage;
    }

    
}
