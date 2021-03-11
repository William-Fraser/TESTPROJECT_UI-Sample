using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int ADDTOSCORE = 0;
    [Space(10)]
    public Text displayedScore;
    public float score = 0;
    [Space(10)]
    public Text btnDogText;
    public GameObject moreDogsImage;
    public bool gainMoreDogs = false;

    // Update is called once per frame
    void Update()
    {
        displayedScore.text = score.ToString();

        if (gainMoreDogs == true)
        {
            moreDogsImage.SetActive(true);
        }
        else 
        {
            moreDogsImage.SetActive(false);
        }
    }

    public void IncreaseScore() 
    {
        score += ADDTOSCORE;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void GainDogs()
    {
        if (gainMoreDogs == false)
        {
            btnDogText.text = "Get rid of Dogs";
            gainMoreDogs = true;
        }
        else if (gainMoreDogs == true)
        {
            btnDogText.text = "Get Dogs";
            gainMoreDogs = false;
        }
    }
}
