using UnityEngine;

public class FrameRateLogger : MonoBehaviour
{
    private float elapsed;
    private float frameTimeTotal;
    private int frameCount;

    void Update()
    {
        elapsed += Time.deltaTime;

        frameTimeTotal += 1f / Time.deltaTime;
        frameCount++;

        if (elapsed >= 5f)
        {
            float averageFPS = frameTimeTotal / frameCount;

            Debug.Log($"Average FPS: {averageFPS:F2}");

            enabled = false;
        }
    }
}