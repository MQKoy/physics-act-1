using UnityEngine;

public class FrameRateController : MonoBehaviour
{
    [SerializeField]
    private int targetFrameRate = 60;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
    }
}