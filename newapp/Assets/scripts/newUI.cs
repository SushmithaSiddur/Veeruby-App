using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class newUI : MonoBehaviour
{
    // Start is called before the first frame update

/**
    public GameObject img;
     public GameObject img2;

     public void buttonEvent()
     {
         if (img.active)
             img.SetActive(false);
         else
             img.SetActive(true);
     }
     public void buttonEvent1()
     {
         if (img2.active)
             img2.SetActive(false);
         else
             img2.SetActive(true);
     }
     
  **/
    
    public void LoadLevel()
    {
        
        SceneManager.LoadScene(1);  //index 1
    }

}
