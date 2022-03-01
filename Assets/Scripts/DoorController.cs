using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimation;
    private float currentTimer;

    private void Awake()
    {
        doorAnimation = GetComponent<Animator>();
        currentTimer = 0;
    }

    private void Update()
    {
        Debug.Log($"{currentTimer}");
        DoorTick();
    }

    private void DoorTick()
    {
        if (!doorAnimation.GetBool("Open"))
        {
            currentTimer += Time.deltaTime;
            doorAnimation.SetFloat("TimeForOpen", currentTimer);
        }
        else
        {
            currentTimer += Time.deltaTime;
            doorAnimation.SetFloat("TimeForClose", currentTimer);
        }

    }

    private void DoorIsOpen()
    {
        currentTimer = 0;
        doorAnimation.SetFloat("TimeForOpen", currentTimer);
        doorAnimation.SetBool("Open", true);
    }
    private void DoorIsClosed()
    {

        doorAnimation.SetBool("Open", false);
    }
}
