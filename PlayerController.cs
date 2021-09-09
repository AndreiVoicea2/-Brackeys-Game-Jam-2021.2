using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : PlayerStats
{

    public Slider slider;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI CoinsText;
    public TextMeshProUGUI CoinsTextUpgrade;
    CircleCollider2D ColliderPlayer;
    public Animator HealthBarAnimation;
    public LoadNextLevel scenefader;
    public GameObject Effect;

    public bool PlayerIsDead = false;

    void Start()
    {
        ColliderPlayer = GetComponent<CircleCollider2D>();
        PlayerCurrentHealth = PlayerMaxHealth;
        slider.maxValue = PlayerMaxHealth;
        slider.value = PlayerCurrentHealth;
        HealthText.text = PlayerCurrentHealth.ToString();
        CoinsText.text = Coins.ToString();
        CoinsTextUpgrade.text = Coins.ToString();
        Physics2D.alwaysShowColliders = true;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCurrentHealth <= 0) Die();
        slider.value = PlayerCurrentHealth;
        HealthText.text = PlayerCurrentHealth.ToString();

        if (PlayerCurrentHealth <= PlayerMaxHealth / 4) HealthBarAnimation.SetBool("LowHealth", true);
         else HealthBarAnimation.SetBool("LowHealth", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyController controlerE = collision.transform.GetComponent<EnemyController>();
            TakeDamage(controlerE.ReturnDamage());
            //Delay Pt Animatie 
            Destroy(collision.transform.gameObject);
            Instantiate(Effect , transform.position , transform.rotation);


        }
    }


    public void TakeDamage(int damage)
    {

        PlayerCurrentHealth -= damage;

    }

    public void Die()
    {
        PlayerIsDead = true;
        scenefader.LoadNextlevel();
        
    }

    public void GetReward(int coins)
    {
        Coins += coins;
        CoinsText.text = Coins.ToString();
        CoinsTextUpgrade.text = Coins.ToString();
    }

    public void ReplenishHealth()
    {
        PlayerCurrentHealth = PlayerMaxHealth;


    }

    public int ReturnDamage()
    {


        return PlayerDamage;
    }

    public int ReturnCoins()
    {

        return Coins;
    }

    public void BoostDamage(int damageModifier)
    {
        Damage += damageModifier;

    }

    public void PayForUpgrade(int coinsModifier)
    {

        Coins -= coinsModifier;
        CoinsText.text = Coins.ToString();
        CoinsTextUpgrade.text = Coins.ToString();
    }
}
