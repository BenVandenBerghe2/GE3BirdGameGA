using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGA : MonoBehaviour ,IGameAnalyticsATTListener
{
    void Start()
    {
    //    if (Application.platform == RuntimePlatform.IPhonePlayer)
    //    {
    //        GameAnalytics.RequestTrackingAuthorization(this);
    //    }
        
            GameAnalytics.Initialize();
        
    }

    public void GameAnalyticsATTListenerNotDetermined()
    {
        GameAnalytics.Initialize();
    }
    public void GameAnalyticsATTListenerRestricted()
    {
        GameAnalytics.Initialize();
    }
    public void GameAnalyticsATTListenerDenied()
    {
        GameAnalytics.Initialize();
    }
    public void GameAnalyticsATTListenerAuthorized()
    {
        GameAnalytics.Initialize();
    }
}

