using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GPGSManager : MonoBehaviour
{
    int count = 0;
    private bool connectoGooglePlay;
    long HighScore;
    private void Start()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
        if (count == 0)
        {
            PlayGamesPlatform.Activate();
        }
        count++;
        HighScore = PlayerPrefs.GetInt("CurrentScore");
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

    public void PostScore()
    {
        Social.ReportScore(HighScore, GPGSIds.leaderboard_flybird, (bool success) => {
            if (success)
            {
                ShowLeaderBoardUI();
                Debug.Log("Show leaderboard");
            }
            else
            {
                Debug.Log("Cant show");
            }
        });
    }

    public void ShowLeaderBoardUI()
    {
        ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI("CgkI5sv_990LEAIQAw");
    }

}
