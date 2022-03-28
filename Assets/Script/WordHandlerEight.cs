using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordHandlerEight : MonoBehaviour
{
    public GameObject popupSalah;
    private Sprite wordImage;
    private int wordCount;
    public int wordQueue;

    [SerializeField]
    private string textTemp;
    private string textAnswer;
    public TextMeshProUGUI textQuiz;
    public GameObject nextQuiz;
    public GameObject prevQuiz;
    public GameObject[] soal;
    public GameObject[] soal1;
    public GameObject[] soal2;
    public GameObject[] soal3;
    public GameObject[] soal4;
    public GameObject[] soal5;
    public GameObject[] soal6;

    public GameObject[] objsoal1;
    public GameObject[] objsoal2;
    public GameObject[] objsoal3;
    public GameObject[] objsoal4;
    public GameObject[] objsoal5;
    public GameObject[] objsoal6;

    public List<GameObject> soalOneTemp;
    public List<GameObject> soalTwoTemp;
    public List<int> soalTerjawabTemp;
    public string[] setSoal;
    public string[] setJawab;
    public string soalOneText;
    public string soalTwoText;
    public string jawabOneText;
    public string jawabTwoText;

    private bool isSoal1;
    private bool isSoal2;
    private bool isSoal3;
    private bool isSoal4;
    private bool trueSoal1 = false;
    private bool trueSoal2 = false;
    private bool trueSoal3 = false;
    private bool trueSoal4 = false;
    private Sprite[] imgsoal1;
    private Sprite[] imgsoal2;
    private Sprite[] imgsoal3;
    private Sprite[] imgsoal4;
    private int nilai;
    bool selesaiGame = false;





    // Start is called before the first frame update
    void Start()
    {
        //ChangeWord(0);
        ChooseQuestion(GameHandler.instanceHandler.pilihsoal1, GameHandler.instanceHandler.pilihsoal2);
        ChangeWord(0);
        soalTerjawabTemp.AddRange(GameHandler.instanceHandler.listSoalTerisi);

    }

    // Update is called once per frame
    void Update()
    {
        if (nilai == 2 && selesaiGame == false)
        {
            GameHandler.instanceHandler.btPostPoint();
            selesaiGame = true;
        }

        if (trueSoal1 == true)
        {
            for (int i = 0; i < soalOneTemp.Count; i++)
            {
                soalOneTemp[i].GetComponent<Image>().sprite = imgsoal1[i];
            }
        }
        if (trueSoal2 == true)
        {
            for (int i = 0; i < soalTwoTemp.Count; i++)
            {
                soalTwoTemp[i].GetComponent<Image>().sprite = imgsoal2[i];
            }
        }
        //if (trueSoal3 == true)
        //{
        //    for (int i = 0; i < soal3.Length; i++)
        //    {
        //        soal3[i].GetComponent<Image>().sprite = imgsoal3[i];
        //    }
        //}
        //if (trueSoal4 == true)
        //{
        //    for (int i = 0; i < soal4.Length; i++)
        //    {
        //        soal4[i].GetComponent<Image>().sprite = imgsoal4[i];
        //    }
        //}

        if (soalTerjawabTemp.Contains(1))
        {
            for (int i = 0; i < soal1.Length; i++)
            {
                soal1[i].GetComponent<Image>().sprite = objsoal1[i].GetComponent<Image>().sprite;
            }
        }
        if (soalTerjawabTemp.Contains(2))
        {
            for (int i = 0; i < soal2.Length; i++)
            {
                soal2[i].GetComponent<Image>().sprite = objsoal2[i].GetComponent<Image>().sprite;
            }
        }
        if (soalTerjawabTemp.Contains(3))
        {
            for (int i = 0; i < soal3.Length; i++)
            {
                soal3[i].GetComponent<Image>().sprite = objsoal3[i].GetComponent<Image>().sprite;
            }
        }
        if (soalTerjawabTemp.Contains(4))
        {
            for (int i = 0; i < soal4.Length; i++)
            {
                soal4[i].GetComponent<Image>().sprite = objsoal4[i].GetComponent<Image>().sprite;
            }
        }
        if (soalTerjawabTemp.Contains(5))
        {
            for (int i = 0; i < soal5.Length; i++)
            {
                soal5[i].GetComponent<Image>().sprite = objsoal5[i].GetComponent<Image>().sprite;
            }
        }
        if (soalTerjawabTemp.Contains(6))
        {
            for (int i = 0; i < soal6.Length; i++)
            {
                soal6[i].GetComponent<Image>().sprite = objsoal6[i].GetComponent<Image>().sprite;
            }
        }


    }

    public void ChooseQuestion(int soalOne, int soalTwo)
    {
        Sprite empty = Resources.Load<Sprite>("Images/empty");
        for (int i = 0; i < soal.Length; i++)
        {
            soal[i].GetComponent<Image>().color = Color.gray;
            soal[i].GetComponent<Image>().sprite = empty;
        }

        if (soalOne == 1)
        {
            for (int i = 0; i < soal1.Length; i++)
            {
                soal1[i].GetComponent<Image>().color = Color.white;
                soalOneTemp.Add(soal1[i]);
            }
        }
        if (soalOne == 2)
        {
            for (int i = 0; i < soal2.Length; i++)
            {
                soal2[i].GetComponent<Image>().color = Color.white;
                soalOneTemp.Add(soal2[i]);
            }
        }
        if (soalOne == 3)
        {
            for (int i = 0; i < soal3.Length; i++)
            {
                soal3[i].GetComponent<Image>().color = Color.white;
                soalOneTemp.Add(soal3[i]);
            }
        }
        if (soalOne == 4)
        {
            for (int i = 0; i < soal4.Length; i++)
            {
                soal4[i].GetComponent<Image>().color = Color.white;
                soalOneTemp.Add(soal4[i]);
            }
        }
        if (soalOne == 5)
        {
            for (int i = 0; i < soal5.Length; i++)
            {
                soal5[i].GetComponent<Image>().color = Color.white;
                soalOneTemp.Add(soal5[i]);
            }
        }
        if (soalOne == 6)
        {
            for (int i = 0; i < soal6.Length; i++)
            {
                soal6[i].GetComponent<Image>().color = Color.white;
                soalOneTemp.Add(soal6[i]);
            }
        }

        //========

        if (soalTwo == 1)
        {
            for (int i = 0; i < soal1.Length; i++)
            {
                soal1[i].GetComponent<Image>().color = Color.white;
                soalTwoTemp.Add(soal1[i]);
            }
        }
        if (soalTwo == 2)
        {
            for (int i = 0; i < soal2.Length; i++)
            {
                soal2[i].GetComponent<Image>().color = Color.white;
                soalTwoTemp.Add(soal2[i]);
            }
        }
        if (soalTwo == 3)
        {
            for (int i = 0; i < soal3.Length; i++)
            {
                soal3[i].GetComponent<Image>().color = Color.white;
                soalTwoTemp.Add(soal3[i]);
            }
        }
        if (soalTwo == 4)
        {
            for (int i = 0; i < soal4.Length; i++)
            {
                soal4[i].GetComponent<Image>().color = Color.white;
                soalTwoTemp.Add(soal4[i]);
            }
        }
        if (soalTwo == 5)
        {
            for (int i = 0; i < soal5.Length; i++)
            {
                soal5[i].GetComponent<Image>().color = Color.white;
                soalTwoTemp.Add(soal5[i]);
            }
        }
        if (soalTwo == 6)
        {
            for (int i = 0; i < soal6.Length; i++)
            {
                soal6[i].GetComponent<Image>().color = Color.white;
                soalTwoTemp.Add(soal6[i]);
            }
        }

        soalOneText = setSoal[soalOne - 1];
        soalTwoText = setSoal[soalTwo - 1];
        jawabOneText = setJawab[soalOne - 1];
        jawabTwoText = setJawab[soalTwo - 1];
    }

    public void ChangeWord(int value)
    {
        isSoal1 = false;
        isSoal2 = false;
        isSoal3 = false;
        isSoal4 = false;
        wordQueue = 0;
        textTemp = "";
        Sprite empty = Resources.Load<Sprite>("Images/empty");

        if (value == 2)
        {
            wordCount++;
        }
        if (value == 1)
        {
            wordCount--;
        }

        for (int i = 0; i < soalOneTemp.Count; i++)
        {
            soalOneTemp[i].GetComponent<Image>().color = Color.white;
            soalOneTemp[i].GetComponent<Image>().sprite = empty;
        }
        for (int i = 0; i < soalTwoTemp.Count; i++)
        {
            soalTwoTemp[i].GetComponent<Image>().color = Color.white;
            soalTwoTemp[i].GetComponent<Image>().sprite = empty;
        }

        switch (wordCount)
        {
            case 0:
                prevQuiz.SetActive(false);
                nextQuiz.SetActive(true);
                textQuiz.text = soalOneText;
                textAnswer = jawabOneText;
                isSoal1 = true;

                for (int i = 0; i < soalOneTemp.Count; i++)
                {
                    soalOneTemp[i].GetComponent<Image>().color = Color.green;
                    soalOneTemp[i].GetComponent<Image>().sprite = empty;
                }
                break;
            case 1:
                prevQuiz.SetActive(true);
                nextQuiz.SetActive(false);
                textQuiz.text = soalTwoText;
                textAnswer = jawabTwoText;
                isSoal2 = true;

                for (int i = 0; i < soalTwoTemp.Count; i++)
                {
                    soalTwoTemp[i].GetComponent<Image>().color = Color.green;
                    soalTwoTemp[i].GetComponent<Image>().sprite = empty;
                }
                break;
                //case 2:
                //    prevQuiz.SetActive(true);
                //    nextQuiz.SetActive(true);
                //    textQuiz.text = "LIKE";
                //    textAnswer = "SUKA";
                //    isSoal3 = true;

                //    for (int i = 0; i < soal3.Length; i++)
                //    {
                //        soal3[i].GetComponent<Image>().color = Color.gray;
                //        soal3[i].GetComponent<Image>().sprite = empty;
                //    }
                //    break;
                //case 3:
                //    prevQuiz.SetActive(true);
                //    nextQuiz.SetActive(false);
                //    textQuiz.text = "DUDUK";
                //    textAnswer = "SIT";
                //    isSoal4 = true;

                //    for (int i = 0; i < soal4.Length; i++)
                //    {
                //        soal4[i].GetComponent<Image>().color = Color.gray;
                //        soal4[i].GetComponent<Image>().sprite = empty;
                //    }
                //    break;
        }
    }

    public void ChooseWord(string word)
    {


        int array1 = soalOneTemp.Count;
        int array2 = soalTwoTemp.Count;
        //int array3 = soal3.Length;
        //int array4 = soal4.Length;
        if (isSoal1 == true)
        {
            if (wordQueue == array1)
            {
                textTemp = textTemp.Remove(textTemp.Length - 1);
                textTemp += word;
                soalOneTemp[wordQueue - 1].GetComponent<Image>().color = Color.magenta;
                soalOneTemp[wordQueue - 1].GetComponent<Image>().sprite = wordImage;
            }
            else
            {
                textTemp += word;
                soalOneTemp[wordQueue].GetComponent<Image>().color = Color.magenta;
                soalOneTemp[wordQueue].GetComponent<Image>().sprite = wordImage;
                wordQueue++;
            }

        }
        if (isSoal2 == true)
        {

            if (wordQueue == array2)
            {
                textTemp = textTemp.Remove(textTemp.Length - 1);
                textTemp += word;
                soalTwoTemp[wordQueue - 1].GetComponent<Image>().color = Color.magenta;
                soalTwoTemp[wordQueue - 1].GetComponent<Image>().sprite = wordImage;
            }
            else
            {
                textTemp += word;
                soalTwoTemp[wordQueue].GetComponent<Image>().color = Color.magenta;
                soalTwoTemp[wordQueue].GetComponent<Image>().sprite = wordImage;
                wordQueue++;
            }
        }
        //if (isSoal3 == true)
        //{
        //    if (wordQueue == array3)
        //    {
        //        textTemp = textTemp.Remove(textTemp.Length - 1);
        //        textTemp += word;
        //        soal3[wordQueue - 1].GetComponent<Image>().color = Color.magenta;
        //        soal3[wordQueue - 1].GetComponent<Image>().sprite = wordImage;
        //    }
        //    else
        //    {
        //        textTemp += word;
        //        soal3[wordQueue].GetComponent<Image>().color = Color.magenta;
        //        soal3[wordQueue].GetComponent<Image>().sprite = wordImage;
        //        wordQueue++;
        //    }
        //}
        //if (isSoal4 == true)
        //{
        //    if (wordQueue == array4)
        //    {
        //        textTemp = textTemp.Remove(textTemp.Length - 1);
        //        textTemp += word;
        //        soal4[wordQueue - 1].GetComponent<Image>().color = Color.magenta;
        //        soal4[wordQueue - 1].GetComponent<Image>().sprite = wordImage;
        //    }
        //    else
        //    {
        //        textTemp += word;
        //        soal4[wordQueue].GetComponent<Image>().color = Color.magenta;
        //        soal4[wordQueue].GetComponent<Image>().sprite = wordImage;
        //        wordQueue++;
        //    }
        //}

    }

    public void ChooseImage(Sprite image)
    {
        wordImage = image;
    }

    public void DeleteImage()
    {
        Sprite empty = Resources.Load<Sprite>("Images/empty");
        wordQueue = 0;
        textTemp = "";
        if (isSoal1 == true)
        {
            for (int i = 0; i < soalOneTemp.Count; i++)
            {
                soalOneTemp[i].GetComponent<Image>().color = Color.green;
                soalOneTemp[i].GetComponent<Image>().sprite = empty;
            }
        }
        if (isSoal2 == true)
        {
            for (int i = 0; i < soalTwoTemp.Count; i++)
            {
                soalTwoTemp[i].GetComponent<Image>().color = Color.green;
                soalTwoTemp[i].GetComponent<Image>().sprite = empty;
            }
        }
        //if(isSoal3 == true)
        //{
        //    for (int i = 0; i < soal3.Length; i++)
        //    {
        //        soal3[i].GetComponent<Image>().color = Color.gray;
        //        soal3[i].GetComponent<Image>().sprite = empty;
        //    }
        //}
        //if(isSoal4 == true)
        //{
        //    for (int i = 0; i < soal4.Length; i++)
        //    {
        //        soal4[i].GetComponent<Image>().color = Color.gray;
        //        soal4[i].GetComponent<Image>().sprite = empty;
        //    }
        //}
    }

    public void CheckWord()
    {
        if (isSoal1 == true)
        {
            if (textTemp == textAnswer && trueSoal1 == false)
            {
                Debug.Log("berhasil");
                imgsoal1 = new Sprite[soalOneTemp.Count];
                for (int i = 0; i < soalOneTemp.Count; i++)
                {
                    imgsoal1[i] = soalOneTemp[i].GetComponent<Image>().sprite;
                }
                trueSoal1 = true;
                nilai++;
                GameObject.Find("benar").GetComponent<TextMeshProUGUI>().text = nilai.ToString();
            }
            else
            {
                popupSalah.SetActive(false);
                popupSalah.SetActive(true);
            }
        }
        if (isSoal2 == true)
        {
            if (textTemp == textAnswer && trueSoal2 == false)
            {
                Debug.Log("berhasil");
                imgsoal2 = new Sprite[soalTwoTemp.Count];
                for (int i = 0; i < soalTwoTemp.Count; i++)
                {
                    imgsoal2[i] = soalTwoTemp[i].GetComponent<Image>().sprite;
                }
                trueSoal2 = true;
                nilai++;
                GameObject.Find("benar").GetComponent<TextMeshProUGUI>().text = nilai.ToString();
            }
            else
            {
                popupSalah.SetActive(false);
                popupSalah.SetActive(true);
            }
        }
        //if (isSoal3 == true)
        //{
        //    if (textTemp == textAnswer && trueSoal3 == false)
        //    {
        //        Debug.Log("berhasil");
        //        imgsoal3 = new Sprite[soal3.Length];
        //        for (int i = 0; i < soal3.Length; i++)
        //        {
        //            imgsoal3[i] = soal3[i].GetComponent<Image>().sprite;
        //        }
        //        trueSoal3 = true;
        //        nilai++;
        //        GameObject.Find("benar").GetComponent<TextMeshProUGUI>().text = nilai.ToString();
        //    }
        //    else
        //    {
        //        Debug.Log("gagal");
        //    }
        //}
        //if (isSoal4 == true)
        //{
        //    if (textTemp == textAnswer && trueSoal4 == false)
        //    {
        //        Debug.Log("berhasil");
        //        imgsoal4 = new Sprite[soal4.Length];
        //        for (int i = 0; i < soal4.Length; i++)
        //        {
        //            imgsoal4[i] = soal4[i].GetComponent<Image>().sprite;
        //        }
        //        trueSoal4 = true;
        //        nilai++;
        //        GameObject.Find("benar").GetComponent<TextMeshProUGUI>().text = nilai.ToString();
        //    }
        //    else
        //    {
        //        Debug.Log("gagal");
        //    }
        //}
    }
}
