using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SuperpowerMechanic : SuperPower
{
    [Header("UI Components")]
    [Space(10)]

    public TextMeshProUGUI text;

    [Header("Keys")]
    [Space(10)]

    public KeyCode tasta;

    [Header("Variables")]
    [Space(10)]

    public int ExplosionDamage = 50;

    [Header("For Animation")]
    [Space(10)]

    public Animator anim;

    [Header("Objects and Vectors")]
    [Space(10)]

    public GameObject ExploziePrefab;
    public Vector3 Marime;
    public Transform transform2;

    bool CanPress = true;

    void Start()
    {

        text.text = Pret.ToString() + " Coins";
    }

    public override void DoSomething()
    {
        base.DoSomething();
        Instantiate(ExploziePrefab, transform2.position, transform2.rotation);
        PlayerInstance.Instance.controler.PayForUpgrade(Pret);
        Collider2D[] cols = Physics2D.OverlapBoxAll(transform2.position, Marime , 0f);
       
        foreach(Collider2D a in cols)
        {
            EnemyController controlerE = a.gameObject.GetComponent<EnemyController>();
            if(controlerE != null)
            controlerE.EnemyTakeDamage(ExplosionDamage);
            StartCoroutine(Delay());
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(tasta) && CanPress)
        {
            if(PlayerInstance.Instance.controler.ReturnCoins() >= Pret)
            DoSomething();
        }

    }

    IEnumerator Delay()
    {
        anim.SetBool("IsOncd", true);
        CanPress = false;
        yield return new WaitForSeconds(couldown);
        CanPress = true;
        anim.SetBool("IsOncd", false);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform2.position, Marime);
    }

    
}
