using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{
    public GameObject pannel;
    public GameObject ins;
    public void play()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Test");
    }
     public void home()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("StartUI");
    }
    public void ClickExit()
             
    {
        Application.Quit();
    }
    public void Instruction()
    {
        ins.SetActive(true);
    }
    public void close()
    {
        pannel.SetActive(false);
    }
    public void Restart()
 {
     SceneManager.LoadScene("test");
 }
    
}
