using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{


    void Start()
    {
        {
            //Detect when the Return key is pressed down
            if (Input.GetKeyDown(KeyCode.Return))
                Debug.Log("Return key was pressed.");
            SceneManager.LoadScene("Start Screen");

        }
    }
}
