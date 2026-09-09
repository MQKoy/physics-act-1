using UnityEngine;

public class CubeA : MonoBehaviour
{
    [SerializeField]
    private float unitsPerSecond = 5f;

    private float elapsed;

    void Update()
    {
        Vector3 pos = transform.position;


        pos.x += unitsPerSecond;

        transform.position = pos;

        elapsed += Time.deltaTime;

        if (elapsed >= 5f)
        {
            Debug.Log($"{name}: Final X = {transform.position.x}");
            enabled = false;
        }
    }
}