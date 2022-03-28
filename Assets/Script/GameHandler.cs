using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using System.Runtime.InteropServices;

public class GameHandler : MonoBehaviour
{
	public static GameHandler instanceHandler;

	public GameObject[] panelTTS;
	public GameObject[] scriptTTS;
	public int getId_user;
	public int pointInt;
	public string rootURLpost = "http://103.122.97.237:1001/mini-game-add-score";
	private string[] value;
	public int pilihsoal1;
	public int pilihsoal2;
	public int tim;
	public GameObject panelStart;
	public GameObject panelSelesai;
	public string pathsplit;

	public string[] soalTerisiString;
	public int[] soalTerisiInt;
	public List<int> listSoalTerisi;

	[DllImport("__Internal")]
	private static extern string FinishGame(string path);

	// Start is called before the first frame update
	private void Awake()
	{
		instanceHandler = this;
	}
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void StartGame(string text)
	{
		value = text.Split(',');
		getId_user = int.Parse(value[0]);
		pilihsoal1 = int.Parse(value[1]);
		pilihsoal2 = int.Parse(value[2]);
		pathsplit = value[3];

		StartCoroutine(GetAnswer());
		//btPostPoint();
	}

	public void btPostPointTwo()
	{
		StartCoroutine(PostPointButton());

	}

	public IEnumerator PostPointButton()
	{
		WWWForm form = new WWWForm();
		form.AddField("myField", "myData");
		//form.AddField("user_id", getId_user);
		//form.AddField("point", 0);
		//form.AddField("game_id", 7);
		//form.AddField("noSoal", pilihsoal1);

		using (
			UnityWebRequest www = UnityWebRequest.Post("https://gamification.psikologicare.com/mini-game-add-score?user_id=" + getId_user + "&point=0&noSoal=" + value[1] + "," + value[2] + "&game_id=7", form))
		{
			yield return www.SendWebRequest();


			if (www.isNetworkError || www.isHttpError)
			{
				Debug.Log(www.error);
				Debug.Log("sala");
			}
			else
			{

				FinishGame(pathsplit);
				Debug.Log("sukses posssssssss");
			}
		}
	}
	public void btPostPoint()
	{
		StartCoroutine(PostPoint());

	}

	public IEnumerator PostPoint()
	{
		WWWForm form = new WWWForm();
		form.AddField("myField", "myData");
		//form.AddField("user_id", getId_user);
		//form.AddField("point", 0);
		//form.AddField("game_id", 7);
		//form.AddField("noSoal", pilihsoal1);

		using (
			UnityWebRequest www = UnityWebRequest.Post("https://gamification.psikologicare.com/mini-game-add-score?user_id=" + getId_user + "&point=0&noSoal=" + value[1] + "," + value[2] + "&game_id=7", form))
		{
			yield return www.SendWebRequest();


			if (www.isNetworkError || www.isHttpError)
			{
				Debug.Log(www.error);
				Debug.Log("sala");
			}
			else
			{
				panelSelesai.SetActive(true);
				yield return new WaitForSeconds(10);
				FinishGame(pathsplit);
				Debug.Log("sukses posssssssss");
			}
		}
	}

	public IEnumerator GetAnswer()
	{
		using (
			UnityWebRequest www = UnityWebRequest.Get("https://gamification.psikologicare.com/user/" + getId_user + "/data-game"))
		{
			yield return www.SendWebRequest();

			if (www.isNetworkError || www.isHttpError)
			{
				Debug.Log(www.error);
				Debug.Log("sala");
			}
			else
			{
				JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(www.downloadHandler.data));
				tim = jsonData["jumlahMember"];

				for (int i = 0; i < jsonData["data"].Count; i++)
				{
					string a = jsonData["data"][i]["noSoal"];
					Debug.Log(a);
					soalTerisiInt = System.Array.ConvertAll(a.Split(','), int.Parse);
					listSoalTerisi.Add(soalTerisiInt[0]);
					listSoalTerisi.Add(soalTerisiInt[1]);

				}

				if (tim == 10)
				{
					panelTTS[0].SetActive(true);
					scriptTTS[0].SetActive(true);
					panelStart.SetActive(false);
				}
				if (tim == 9)
				{
					panelTTS[1].SetActive(true);
					scriptTTS[1].SetActive(true);
					panelStart.SetActive(false);
				}
				if (tim == 8)
				{
					panelTTS[2].SetActive(true);
					scriptTTS[2].SetActive(true);
					panelStart.SetActive(false);
				}
				if (tim == 7)
				{
					panelTTS[3].SetActive(true);
					scriptTTS[3].SetActive(true);
					panelStart.SetActive(false);
				}
				if (tim == 6)
				{
					panelTTS[4].SetActive(true);
					scriptTTS[4].SetActive(true);
					panelStart.SetActive(false);
				}
				if (tim == 5)
				{
					panelTTS[5].SetActive(true);
					scriptTTS[5].SetActive(true);
					panelStart.SetActive(false);
				}
				if (tim == 4)
				{
					panelTTS[6].SetActive(true);
					scriptTTS[6].SetActive(true);
					panelStart.SetActive(false);
				}
				if (tim == 3)
				{
					panelTTS[7].SetActive(true);
					scriptTTS[7].SetActive(true);
					panelStart.SetActive(false);
				}

				//for (int i = 0; i < panelTTS.Length; i++)
				//{
				//    if (value[1] == (i + 1).ToString())
				//    {
				//        panelTTS[i].SetActive(true);
				//        scriptTTS[i].SetActive(true);
				//        panelStart.SetActive(false);
				//    }
				//}
			}
		}
	}

}
