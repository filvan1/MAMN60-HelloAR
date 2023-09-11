using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOtherScene : MonoBehaviour
{

    public void ChangeScene(){
        if(SceneManager.GetActiveScene().buildIndex == 1){
            SceneManager.LoadScene(0);
        } else{
            SceneManager.LoadScene(1);
        }

    }
}
