using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class MenuManager : MonoBehaviour {

    public void SceneSwitch(){
        SceneManager.LoadScene("Level");
}

    public void QuitGame(){
        Application.Quit();
    }
}
