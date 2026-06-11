using UnityEngine;

public class PulseAnimation : MonoBehaviour
{
    [SerializeField] private float speed = 5f;      // Tốc độ đập của button
    [SerializeField] private float pulseScale = 0.1f; // Độ to nhỏ của button

    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Tạo biến thiên theo hình sin
        float scale = Mathf.Sin(Time.unscaledTime * speed) * pulseScale;

        // Áp dụng vào scale của object
        transform.localScale = initialScale + new Vector3(scale, scale, 0);
    }
}