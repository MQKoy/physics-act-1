using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubeC : MonoBehaviour
{
    [SerializeField]
    private float unitsPerSecond = 5f;

    private Rigidbody rb;
    private float elapsed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 pos = rb.position;

            pos.x += unitsPerSecond;

        rb.position = pos;
    }

    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= 5f)
        {
            Debug.Log($"{name}: Final X = {rb.position.x}");
            enabled = false;
        }
    }
}