using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlowTimePower : SuperPower
{

    [Header("UI Components")]
    [Space(10)]

    public TextMeshProUGUI text;


    [Header("Keys")]
    [Space(10)]

    public KeyCode tasta;

    [Header("Variables")]
    [Space(10)]

    public float couldownPressButton;

    [Header("Objects and Vectors")]
    [Space(10)]

   
    public GameObject SlowTimeEff;
    public Transform transform3;

    [Header("For Animation")]
    [Space(10)]

    public Animator anim;


    bool CanPress = true;
    
    void Start()
    {
        text.text = Pret.ToString() + " Coins";
        
    }


    public override void DoSomething()
    {
        base.DoSomething();
        PlayerInstance.Instance.controler.PayForUpgrade(Pret);
        Time.timeScale = 0.3f;
        Instantiate(SlowTimeEff, transform3.position, transform3.rotation);
        StartCoroutine(Delay());
    }

    void Update()
    {
        if (Input.GetKeyDown(tasta) && CanPress)
        {
            if (PlayerInstance.Instance.controler.ReturnCoins() >= Pret)
                DoSomething();
        }
    }

    IEnumerator Delay()
    {
        anim.SetBool("IsOncd", true);
        CanPress = false;
        yield return new WaitForSecondsRealtime (couldown);
        Time.timeScale = 1f;
        yield return new WaitForSeconds(couldownPressButton);
        CanPress = true;
        anim.SetBool("IsOncd", false);
    }

    public void BoostColdown(float modifier2)
    {

        couldown += modifier2;

    }
}
