using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

    //Make sure to attach these Buttons in the Inspector
    public Button start_b, help_b;


    void Start()
    {
        Button btn1 = start_b.GetComponent<Button>();
        Button btn2 = help_b.GetComponent<Button>();


        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(delegate {TaskWithParameters("Hello"); });
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        SceneManager.LoadScene("Game");
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button is clicked
        Debug.Log(message);
        SceneManager.LoadScene("Help");
    }

    //public void 

    //OnMouseClick() {SceneManager.LoadScene("Here put the name of the scene"); }
}