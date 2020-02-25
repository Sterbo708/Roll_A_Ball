using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
    {
    //Make sure to attach these Buttons in the Inspector
    public Button back_b;

    void Start()
    {
        Button btn1 = back_b.GetComponent<Button>();

        //Calls the TaskOnClick method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("Should go back to the Start Menu");
        SceneManager.LoadScene("Start Screen");
    }
}