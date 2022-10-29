using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadScene : MonoBehaviour
{

   

    // Start is called before the first frame update
    void Start()
    {
       
    }

public void PressLevel1(){
    UnityEngine.SceneManagement.SceneManager.LoadScene("Main Scene");
} 

public void PressLevel2(){

}

public void QuitButt(){
    Application.Quit();
}

public void MainMenuButt(){
   
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
