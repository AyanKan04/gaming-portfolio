using UnityEngine;

public class InfinityMove : MonoBehaviour
{
    [Header("Cài đặt di chuyển")]
    public float speed = 3f;      // Tốc độ chạy
    public float width = 100f;    // Độ rộng ngang (pixel)
    public float height = 50f;    // Độ cao dọc (pixel)

    private Vector3 startPos;
    private float timer;

    void Start()
    {
        // Lưu lại vị trí tâm bàn tay tutorital
        startPos = transform.localPosition;
    }

    void Update()
    {
        timer += Time.deltaTime * speed;

        // Công thức hình vô cực (Figure-8)
        float x = Mathf.Sin(timer) * width;
        float y = Mathf.Sin(timer * 2f) * height / 2f;

        // Cập nhật vị trí
        transform.localPosition = startPos + new Vector3(x, y, 0);
    }
}