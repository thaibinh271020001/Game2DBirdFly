using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase CharacterDB;

    public Animator characterAnimator;

    public static int ChooseOption;

    void Start()
    {
        ChooseOption = PlayerPrefs.GetInt("SelectionCharacter");
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
    }
    public void UpdateCharacter(int ChooseOption)
    {
        Character character = CharacterDB.GetCharacter(ChooseOption);
        characterAnimator.runtimeAnimatorController = character.characterController;
        save();
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
