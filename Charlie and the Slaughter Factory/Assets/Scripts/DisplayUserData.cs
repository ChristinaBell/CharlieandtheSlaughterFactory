using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayUserData : MonoBehaviour {

	public void Start() {
		int highScore = PlayerPrefs.GetInt(name);
		if (highScore != 0) {
			gameObject.GetComponent<Text>().text = "High Score: " + highScore;
		}
	}

	public void UpdateCurrentScore(int newScore) {
		int currentScore = PlayerPrefs.GetInt("CurrentScore");
		PlayerPrefs.SetInt("CurrentScore", currentScore + newScore);
	}

	public static void UpdateDataHighScore() {
		int newScore = PlayerPrefs.GetInt("CurrentScore");
		string currentGame = PlayerPrefs.GetString("CurrentGame");
		int highScore = PlayerPrefs.GetInt(currentGame + "HighScore");
		if (highScore < newScore) {
			PlayerPrefs.SetInt(currentGame + " HighScore", newScore);
		}
	}
		
}
