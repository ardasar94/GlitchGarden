using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;


    float lives;
    Text liveText;
    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        liveText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("difficulty is: " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {
        liveText.text = lives.ToString();
    }

    public void LooseLive()
    {
        lives--;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
