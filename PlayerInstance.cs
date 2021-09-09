using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : MonoBehaviour
{
   public static PlayerInstance Instance;
    public PlayerController controler;

    #region Singleton
    private void Awake()
    {
        Instance = this;
    }
    #endregion
}
