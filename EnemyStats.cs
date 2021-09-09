using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField]
    private int ViataMaximaInamic = 100;
    protected int EnemyMaxHealth { get { return ViataMaximaInamic; } set {; } }


    [SerializeField]
    private int DamageInamic = 20;
    protected int EnemyDamage { get { return DamageInamic; } set {; } }


    [SerializeField]
    private int CoinsDrop = 10;
    protected int EnemyDropReward { get { return CoinsDrop; } set {; } }

    [SerializeField]
    protected int EnemyCurrentHealth;
}
