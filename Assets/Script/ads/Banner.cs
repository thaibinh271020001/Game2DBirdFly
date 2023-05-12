using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Banner : MonoBehaviour
{
    /*BannerView bannerView;
    string adUnitId = "ca-app-pub-3940256099942544/6300978111";

    InterstitialAd interstitialAd;
    string interstitialAdId = "ca-app-pub-3940256099942544/1033173712";
    public void Start()
    {
        MobileAds.Initialize(initStatus => { });
        RequestBanner();
    }

    void RequestBanner()
    {
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }
    
    void RequestInterstitial()
    {
        interstitialAd = new InterstitialAd(interstitialAdId);
        AdRequest request = new AdRequest.Builder().Build();
    }*/

    public static Banner Instance;
    InterstitialAd interstitialAd;
    string adUnitId = "ca-app-pub-3940256099942544/1033173712";

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            LoadInterstitialAd();
        });
    }

    public void LoadInterstitialAd()
    {
        // Clean up the old ad before loading a new one.
        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        Debug.Log("Loading the interstitial ad.");

        // create our request used to load the ad.
        var adRequest = new AdRequest.Builder()
                .AddKeyword("unity-admob-sample")
                .Build();

        // send the request to load the ad.
        InterstitialAd.Load(adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
              // if error is not null, the load request failed.
              if (error != null || ad == null)
                {
                    Debug.LogError("interstitial ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Interstitial ad loaded with response : "
                          + ad.GetResponseInfo());

                interstitialAd = ad;
                RegisterEventHandlers(interstitialAd);
            });
    }

    public void ShowAd()
    {
        if (interstitialAd != null && interstitialAd.CanShowAd())
        {
            Debug.Log("Showing interstitial ad.");
            interstitialAd.Show();
        }
        else
        {
            Debug.LogError("Interstitial ad is not ready yet.");
        }
    }

    private void RegisterEventHandlers(InterstitialAd ad)
    {
        // Raised when the ad is estimated to have earned money.
        ad.OnAdPaid += (AdValue adValue) =>
        {
            Debug.Log(String.Format("Interstitial ad paid {0} {1}.",
                adValue.Value,
                adValue.CurrencyCode));
        };
        // Raised when an impression is recorded for an ad.
        ad.OnAdImpressionRecorded += () =>
        {
            Debug.Log("Interstitial ad recorded an impression.");
        };
        // Raised when a click is recorded for an ad.
        ad.OnAdClicked += () =>
        {
            Debug.Log("Interstitial ad was clicked.");
        };
        // Raised when an ad opened full screen content.
        ad.OnAdFullScreenContentOpened += () =>
        {
            Debug.Log("Interstitial ad full screen content opened.");
        };
        // Raised when the ad closed full screen content.
        ad.OnAdFullScreenContentClosed += () =>
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Interstitial ad full screen content closed. and 123");
            LoadInterstitialAd();
        };
        // Raised when the ad failed to open full screen content.
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.LogError("Interstitial ad failed to open full screen content " +
                           "with error : " + error);
            LoadInterstitialAd();
        };
    }

}