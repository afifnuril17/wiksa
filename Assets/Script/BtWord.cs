using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtWord : MonoBehaviour
{
    private WordHandler wordHandler;
    private WordHandlerTwo wordHandlerTwo;
    private WordHandlerThree wordHandlerThree;
    private WordHandlerFour wordHandlerFour;
    private WordHandlerFive wordHandlerFive;
    private WordHandlerSix wordHandlerSix;
    private WordHandlerSeven wordHandlerSeven;
    private WordHandlerEight wordHandlerEight;
    // Start is called before the first frame update
    private void Start()
    {
        wordHandler = GameObject.FindObjectOfType<WordHandler>();
        wordHandlerTwo = GameObject.FindObjectOfType<WordHandlerTwo>();
        wordHandlerThree = GameObject.FindObjectOfType<WordHandlerThree>();
        wordHandlerFour = GameObject.FindObjectOfType<WordHandlerFour>();
        wordHandlerFive = GameObject.FindObjectOfType<WordHandlerFive>();
        wordHandlerSix = GameObject.FindObjectOfType<WordHandlerSix>();
        wordHandlerSeven = GameObject.FindObjectOfType<WordHandlerSeven>();
        wordHandlerEight = GameObject.FindObjectOfType<WordHandlerEight>();
    }

    public void BtChooseWord()
    {
        Sprite image = gameObject.GetComponent<Image>().sprite;
        string word = gameObject.GetComponent<Image>().sprite.name;

        if (GameHandler.instanceHandler.tim == 10)
        {
            wordHandler.ChooseImage(image);
            wordHandler.ChooseWord(word);
        }
        if (GameHandler.instanceHandler.tim == 9)
        {
            wordHandlerTwo.ChooseImage(image);
            wordHandlerTwo.ChooseWord(word);
        }
        if (GameHandler.instanceHandler.tim == 8)
        {
            wordHandlerThree.ChooseImage(image);
            wordHandlerThree.ChooseWord(word);
        }
        if (GameHandler.instanceHandler.tim == 7)
        {
            wordHandlerFour.ChooseImage(image);
            wordHandlerFour.ChooseWord(word);
        }
        if (GameHandler.instanceHandler.tim == 6)
        {
            wordHandlerFive.ChooseImage(image);
            wordHandlerFive.ChooseWord(word);
        }
        if (GameHandler.instanceHandler.tim == 5)
        {
            wordHandlerSix.ChooseImage(image);
            wordHandlerSix.ChooseWord(word);
        }
        if (GameHandler.instanceHandler.tim == 4)
        {
            wordHandlerSeven.ChooseImage(image);
            wordHandlerSeven.ChooseWord(word);
        }
        if (GameHandler.instanceHandler.tim == 3)
        {
            wordHandlerEight.ChooseImage(image);
            wordHandlerEight.ChooseWord(word);
        }


    }

}
