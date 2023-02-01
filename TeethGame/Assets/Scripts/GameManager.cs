using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    private Player2Input player2;
    [SerializeField] private Animator roofAnimator;

    bool isRoofOpen = false;

    private void Awake()
    {
        player2 = new Player2Input();
    }

    private void OnEnable()
    {
        player2.Enable();
    }

    private void OnDisable()
    {
        player2.Disable();
    }

    private void Update()
    {
        if (player2 != null)
        {
            if (player2.Player2.Open.triggered)
            {
                if (!isRoofOpen)
                {
                    isRoofOpen = true;
                    roofAnimator.SetTrigger("Open");
                }
                else
                {
                    isRoofOpen = false;
                    roofAnimator.SetTrigger("Close");
                }

            }
        }
    }
}
