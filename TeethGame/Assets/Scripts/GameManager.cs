using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public float timerStart = 120;
    public int score = 0;

    private Player2Input player2;
    [SerializeField] private Animator roofAnimator;
    [SerializeField] private TextMeshProUGUI scoreUI;
    [SerializeField] private TextMeshProUGUI timeUI;

    private float remainingTime;
    bool isRoofOpen = false;
    bool timerisRunning = true;

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

    private void Start()
    {
        remainingTime = timerStart;
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

        if (timerisRunning)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else
            {
                //END GAME
                remainingTime = 0;
                timerisRunning = false;
            }
        }
        scoreUI.text = "Score: " + score.ToString();
        DisplayTime(remainingTime);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeUI.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
