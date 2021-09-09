using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{

    
    protected const int PlayerMaxHealth = 100;
    //Se Modifica Mai tarziu din constanta daca este nevoie
    [SerializeField]
    protected int Damage = 10;
    protected int PlayerCurrentHealth { get; set; }
    

    protected int PlayerDamage { get { return Damage; }  set {  ;} }


    [SerializeField]
    protected int Coins = 0;
    

}
