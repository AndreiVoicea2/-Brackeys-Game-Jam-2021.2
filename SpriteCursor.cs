using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteCursor : MonoBehaviour
{
    public Texture2D ImagineCursorCandApesi;
    public Texture2D ImagineCursorInitiala;
    public GameObject Effect;
    public Button buton;


    public void ChangeCursorEntry()
    {
        if(buton.interactable == true)
        Cursor.SetCursor(ImagineCursorCandApesi, new Vector2 (0, 0) , CursorMode.Auto);


    }

    public void ChangeCursorExit()
    {
        if (buton.interactable == true)
            Cursor.SetCursor(ImagineCursorInitiala, new Vector2(0, 0), CursorMode.Auto);


    }

    public void SpawnEffect()
    {

        Instantiate(Effect, transform.position, transform.rotation);

    }

}
