using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Upgrade", menuName = "UpgradeType", order = 1)]
public class UpgradeType : ScriptableObject
{
    public Sprite ImagineUpgrade;
    

    [Header("Variables")]
    [Space(10)]

    public string DescriereUpgrade;
    public int NumarMaximDeUpgrades = 5;
    public int PretUpgrade = 20;
    public int pretInitial;
    public int modidier;
    public int InflatiaGen = 10;

    public void Inflatie()
    {
        PretUpgrade += InflatiaGen;


    }

}
