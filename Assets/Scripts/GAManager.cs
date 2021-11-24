using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class GAManager : MonoBehaviour
{
    public static GAManager instance;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        GameAnalytics.Initialize();
    }

    public void OnLevelComlete(int level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Level:" + level);
        Debug.Log("LEVEL Complete:" + level);
    }
    public void OnLevelFailed(int level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "Level:" + level);
        Debug.Log("LEVEL Fail:" + level);
    }

    public void OnLevelButtonTryAgain(int level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Level:" + level);
        Debug.Log("LEVEL restart:" + level);
    }
}
