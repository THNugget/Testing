using System.Collections;
using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;

public class KeypadNumenter : MonoBehaviour
{
    public TMP_InputField CharHolder;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;

    private bool complete = false;

    public GameObject door;

    public PlayerMovement playerMovement;

    public string password = "2285";

    private const int maxChars = 4;

    public void b1()
    {
        CharHolder.text = CharHolder.text + "1";
    }
    public void b2()
    {
        CharHolder.text = CharHolder.text + "2";
    }
    public void b3()
    {
        CharHolder.text = CharHolder.text + "3";
    }
    public void b4()
    {
        CharHolder.text = CharHolder.text + "4";
    }
    public void b5()
    {
        CharHolder.text = CharHolder.text + "5";
    }
    public void b6()
    {
        CharHolder.text = CharHolder.text + "6";
    }
    public void b7()
    {
        CharHolder.text = CharHolder.text + "7";
    }
    public void b8()
    {
        CharHolder.text = CharHolder.text + "8";
    }
    public void b9()
    {
        CharHolder.text = CharHolder.text + "9";
    }
    public void b0()
    {
        CharHolder.text = CharHolder.text + "0";
    }
    //public void clear()
    //{
    //    CharHolder.text = null;
    //}
    //public void enter()
    //{
    //    if (CharHolder.text == password)
    //    {
    //        Debug.Log("Access Granted");
    //    }
    //    else
    //    {
    //        Debug.Log("Access Denied");
    //    }

    //}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playerMovement.canMove = true;
            CharHolder.text = null;
            gameObject.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        if (CharHolder.text.Length >= maxChars)
        {
            if (CharHolder.text == password)
            {
                CharHolder.text = "Access Granted";
                StartCoroutine(DelayAction(1f));
            }
            else if (CharHolder.text != password && CharHolder.text != "Access Granted")
            {
                CharHolder.text = "Access Denied";
                StartCoroutine(ResetInputField(1f));
            }
        }
    }
    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        playerMovement.canMove = true;
        CharHolder.text = null;
        complete = true;
        door.SetActive(false);
        gameObject.SetActive(false);
    }
    IEnumerator ResetInputField(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        CharHolder.text = null;
    }
    public void openKeypad()
    {
        if(complete == false)
        {
            gameObject.SetActive(true);
            playerMovement.canMove = false;
        }
        else
        {
            Debug.Log("Keypad is already done.");
        }
    }
}
