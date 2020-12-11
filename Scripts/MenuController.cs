using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    //Fade volor
    public Color fadeColor = Color.white;
    public Image soundButtonStart;
    public Image soundButtonEnd;
    public Sprite soundOn;
    public Sprite soundOff;
    public GameObject CreditPanel;

    // Use this for initialization
    void Start () {
        //Set looks for the button at start
        SetSoundButton();
    }
    //Put your leaderboard code here
    public void Leaderboard() {
        Debug.Log("Leaderboard Goes here , Click to Open In IDE");
    }

    //Restart the Game
    public void Replay() {
        Initiate.Fade(SceneManager.GetActiveScene().name, fadeColor, 2.0f);
    }

    public void ChangeSound() {
        //Turn sound on or off

        if (PlayerPrefs.GetInt("Sound", 1) == 1) {
            PlayerPrefs.SetInt("Sound", 0);
        }
        else if (PlayerPrefs.GetInt("Sound", 1) == 0)
        {
            PlayerPrefs.SetInt("Sound", 1);
        }

        SetSoundButton();

    }

    //Set how the audio button looks
    void SetSoundButton() {

        if (!soundOn || !soundOff || !soundButtonEnd || !soundButtonStart)
            Debug.LogError("Please Assign all the variables");

        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            AudioListener.volume = 1.0f;
            soundButtonStart.sprite = soundOn;
            soundButtonEnd.sprite = soundOn;
        }
        else {
            AudioListener.volume = 0.0f;
            soundButtonStart.sprite = soundOff;
            soundButtonEnd.sprite = soundOff;
        }
    }

    public void Credit()
    {
        CreditPanel.SetActive(true);
    }

    public void CloseCreditPanel()
    {
        CreditPanel.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
