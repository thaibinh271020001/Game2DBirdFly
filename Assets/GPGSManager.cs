using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GPGSManager : MonoBehaviour
{
    private bool connectoGooglePlay;
    private void Start()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }
    private void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            connectoGooglePlay = true;
            Debug.LogWarning("Dang nhap thanh cong");
        }
        else
        {
            connectoGooglePlay = false;
            Debug.LogWarning("Dang nhap that bai");
        }
    }
}
