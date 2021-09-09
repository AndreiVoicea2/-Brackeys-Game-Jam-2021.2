using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    
    public Animator transition;
    public float transitionTime = 1f;
   


    public void LoadNextlevel()
    {

        StartCoroutine(LoadLevel(1));

    }
        
    IEnumerator LoadLevel (int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);


    }


    public void Quit()
    {

        Application.Quit();


    }


    /*
    public void RestartLevel()
    {

        Application.LoadLevel(2);
    }

    

        
    public void Menu1()
    {
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Application.LoadLevel(1);
       
       
    }

    */

}
