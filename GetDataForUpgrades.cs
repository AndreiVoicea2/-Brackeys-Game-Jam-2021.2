using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetDataForUpgrades : MonoBehaviour
{

    [Header("UI Components")]
    [Space(10)]

    public Image Imagine;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public Slider ProgressBar;
    public Button butonUpgrade;


    [Header("Script Components")]
    [Space(10)]

    public SlowTimePower power;
    public SuperpowerMechanic mechanic;
    public UpgradeType upgradeScriptabaleObject;

    [Header("Objects")]
    [Space(10)]

    public GameObject Shield;

    int CateUpgradeuriSunt = 0;
    
    
    void Start()
    {
        upgradeScriptabaleObject.PretUpgrade = upgradeScriptabaleObject.pretInitial;
        Imagine.sprite = upgradeScriptabaleObject.ImagineUpgrade;
        text.text = upgradeScriptabaleObject.DescriereUpgrade;
        text2.text = "Upgrade - " + upgradeScriptabaleObject.PretUpgrade + " Coins";
        ProgressBar.maxValue = upgradeScriptabaleObject.NumarMaximDeUpgrades;
        ProgressBar.value = CateUpgradeuriSunt;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInstance.Instance.controler.ReturnCoins() < upgradeScriptabaleObject.PretUpgrade || upgradeScriptabaleObject.NumarMaximDeUpgrades == CateUpgradeuriSunt )
        {
            butonUpgrade.interactable = false;
            if( CateUpgradeuriSunt == upgradeScriptabaleObject.NumarMaximDeUpgrades) text2.text = "Max";
        }
        else
        {
            butonUpgrade.interactable = true;

        }
    }

    public void GiveUpgradeForDamage()
    {
        PlayerInstance.Instance.controler.BoostDamage(upgradeScriptabaleObject.modidier);
        PlayerInstance.Instance.controler.PayForUpgrade(upgradeScriptabaleObject.PretUpgrade);
        upgradeScriptabaleObject.Inflatie();
        text2.text = "Upgrade - " + upgradeScriptabaleObject.PretUpgrade + " Coins";
        CateUpgradeuriSunt++;
        ProgressBar.value = CateUpgradeuriSunt;

    }

    public void GiveUpgradeForExplosion()
    {
        if (mechanic != null) mechanic.ExplosionDamage += upgradeScriptabaleObject.modidier;
        PlayerInstance.Instance.controler.PayForUpgrade(upgradeScriptabaleObject.PretUpgrade);
        upgradeScriptabaleObject.Inflatie();
        text2.text = "Upgrade - " + upgradeScriptabaleObject.PretUpgrade + " Coins";
        CateUpgradeuriSunt++;
        ProgressBar.value = CateUpgradeuriSunt;


    }


    public void GiveUpgradeForSlow()
    {
        if (power != null) power.BoostColdown(upgradeScriptabaleObject.modidier);
        PlayerInstance.Instance.controler.PayForUpgrade(upgradeScriptabaleObject.PretUpgrade);
        upgradeScriptabaleObject.Inflatie();
        text2.text = "Upgrade - " + upgradeScriptabaleObject.PretUpgrade + " Coins";
        CateUpgradeuriSunt++;
        ProgressBar.value = CateUpgradeuriSunt;


    }

    public void GiveUpgradeForPowerShield()
    {
        if (Shield != null) Shield.SetActive(true);
        PlayerInstance.Instance.controler.PayForUpgrade(upgradeScriptabaleObject.PretUpgrade);
        CateUpgradeuriSunt++;
        ProgressBar.value = CateUpgradeuriSunt;

    }

  
}
