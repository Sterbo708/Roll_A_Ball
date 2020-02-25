using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController_1 : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float timeLeft;
    public Text countText;
    public Text winText;
    public Text wallText;

    private Rigidbody rb;
    private int count;
    private int wall;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();
        SetWallText();
        winText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        if (IsGrounded() && (Input.GetKeyDown(KeyCode.Space)))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        Physics.gravity = new Vector3(0, -1.0F, 0);

    }


    private bool IsGrounded()
    { 
        return false; 
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup_1"))
        {
            other.gameObject.SetActive(false);
            speed = (speed + 5);
        }
        else if (other.gameObject.CompareTag("Powerup_2"))
        {
            other.gameObject.SetActive(false);
            speed = (speed + 2);
        }
        else if (other.gameObject.CompareTag("Powerup_3"))
        {
            other.gameObject.SetActive(false);
            speed = (speed - 5);
        }
        else if (other.gameObject.CompareTag("Powerup_4"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("Wall"))
        {
            other.gameObject.SetActive(true);
            wall = wall + 1;
            SetWallText();
        }
        else if (other.gameObject.CompareTag("Checkpoint"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Next"))
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene("WinScreen");
        }
    }

    void SetWallText()
    {
        wallText.text = "Wall Hit: " + wall.ToString();
        if (wall >= 10)
            wallText.text = "Man....you hit a lot of walls.";
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 5)
        {
            winText.text = "You Win! All Special Emojis Collected.";
        }
    }
}
