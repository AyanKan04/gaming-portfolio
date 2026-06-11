using UnityEngine;

public class VehicleMove : MonoBehaviour
{
    private float speed;
    private float lifeTime;
    private Vector3 direction;

    public void Setup(float moveSpeed, float duration, Vector3 moveDir)
    {
        speed = moveSpeed;
        lifeTime = duration;
        direction = moveDir;

        // Xoay đầu xe về hướng chạy
        if (direction != Vector3.zero)
        {
            transform.forward = direction;
        }

        // Tự hủy sau một khoảng thời gian để tránh rác bộ nhớ
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Xe di chuyển thẳng theo hướng đã định
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}