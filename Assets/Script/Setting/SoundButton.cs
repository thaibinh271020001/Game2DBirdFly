using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    int SettingVolume = 0;
    public GameObject ClickSound;
    public GameObject DeadSound;

    public Text SoundText;
    string OnOff;
    bool BlOnOff = true;

    void Start()
    {
        OnOff = PlayerPrefs.GetString("SaveVolume");
        SoundText.text = "" + OnOff;


        Debug.Log("Volume: " + SettingVolume);

        
    }

    private void Update()
    {
        SettingVolume = PlayerPrefs.GetInt("SettingVolume");
        if (SettingVolume == 0)
        {
            AudioSource volum = ClickSound.GetComponent<AudioSource>();
            AudioSource volumDead = DeadSound.GetComponent<AudioSource>();
            volum.volume = 0;
            volumDead.volume = 0;
        }
        else
        {
            AudioSource volum = ClickSound.GetComponent<AudioSource>();
            AudioSource volumDead = DeadSound.GetComponent<AudioSource>();
            volum.volume = 1;
            volumDead.volume = 1;
        }
    }
    public void OnOffSound()
    {
        if (BlOnOff == true)
        {
            OnOff = "Sound: On";
            PlayerPrefs.SetInt("SettingVolume", 1);
        }
        else
        {
            OnOff = "Sound: Off"; 
            PlayerPrefs.SetInt("SettingVolume", 0);
        }
        SoundText.text = "" + OnOff;
        BlOnOff = !BlOnOff;

        PlayerPrefs.SetString("SaveVolume", OnOff);
    }
}
