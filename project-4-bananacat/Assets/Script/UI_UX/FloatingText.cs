using UnityEngine;
using TMPro;

public class FloatingText : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float lifeTime = 0.8f;
    [SerializeField] private Vector3 randomOffset = new Vector3(0.5f, 0f, 0.5f);

    [Header("Visual")]
    [SerializeField] private AnimationCurve scaleCurve; // tạo độ co giãn (vẽ hình sin)
    [SerializeField] private TextMeshPro textMesh; // Dùng TextMeshPro (3D) - đặt trong không gian 3D

    private float timer;
    private Vector3 baseScale = Vector3.one;

    void Start()
    {
        // Thêm một chút ngẫu nhiên để các số không bị chồng khít lên nhau
        transform.position += new Vector3(
            Random.Range(-randomOffset.x, randomOffset.x),
            1f,
            Random.Range(-randomOffset.z, randomOffset.z)
        );

        // Tự hủy sau khi hết đời
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Bay lên theo trục Y
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        // Xoay chữ luôn hướng về Camera để người chơi luôn đọc được
        if (Camera.main != null)
            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);

        // Hiệu ứng Scale dựa trên Animation Curve
        timer += Time.deltaTime;
        float scaleVal = scaleCurve.Evaluate(timer / lifeTime);

        transform.localScale = baseScale * scaleVal;
    }

    public void SetText(string text, Color color)
    {
        textMesh.text = text;
        textMesh.color = color;
    }

    // nhận kích thước từ Player
    public void Initialize(string text, Color color, Vector3 playerScale)
    {
        textMesh.text = text;
        textMesh.color = color;
        // Lưu lại scale của player làm mốc
        baseScale = playerScale;
    }
}