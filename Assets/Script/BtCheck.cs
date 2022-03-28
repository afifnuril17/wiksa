using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtCheck : MonoBehaviour
{
    private WordHandler wordHandler;
    // Start is called before the first frame update
    private void Awake()
    {
        wordHandler = GameObject.FindObjectOfType<WordHandler>();
    }

    public void BtChooseWord()
    {
        string word = gameObject.GetComponent<Image>().sprite.name;
    }

}
