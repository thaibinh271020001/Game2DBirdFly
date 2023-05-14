using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase CharacterDB;

    public Animator characterAnimator;

    public int ChooseOption;

    void Start()
    {
        Load();
        UpdateCharacter(ChooseOption);

    }

    public void ChooseToChangeCharacter()
    {
        ChooseOption++;
        if(ChooseOption == 16)
        {
            ChooseOption = 0;
        }
        UpdateCharacter(ChooseOption);
        save();
    }
    public void UpdateCharacter(int ChooseOption)
    {
        Character character = CharacterDB.GetCharacter(ChooseOption);
        characterAnimator.runtimeAnimatorController = character.characterController;
    }
    public void Load()
    {
        ChooseOption = PlayerPrefs.GetInt("ChooseOption");
    }
    public void save()
    {
        PlayerPrefs.SetInt("ChooseOption", ChooseOption);
    }
}
