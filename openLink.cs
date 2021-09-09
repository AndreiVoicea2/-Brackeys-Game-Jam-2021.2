using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLink : MonoBehaviour
{
    public void AccesLink(string Link)
    {
        Application.OpenURL(Link);


    }


    public void Quit()
    {
        Application.Quit();
    }
}
