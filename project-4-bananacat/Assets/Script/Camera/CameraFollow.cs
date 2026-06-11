using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    [Header("Follow")]
    [SerializeField] private float followSpeed = 8f;

    [Header("Base Offset")]
    [SerializeField] private Vector3 baseOffset = new Vector3(0, 12f, -10f);

    [Header("Zoom")]
    [SerializeField] private float heightMultiplier = 1.5f; // tăng Y
    [SerializeField] private float distanceMultiplier = 1.2f; // tăng Z

    [SerializeField] private float maxScaleEffect = 10f;

    void LateUpdate()
    {
        float scale = target.localScale.x;

        //scaleFactor mạnh hơn để thấy rõ
        float scaleFactor = Mathf.Clamp(scale, 1f, maxScaleEffect);

        //tăng offset theo scale
        Vector3 dynamicOffset = baseOffset;

        dynamicOffset.y += scaleFactor * heightMultiplier * 5f;   // tăng chiều cao
        dynamicOffset.z -= scaleFactor * distanceMultiplier * 5f; // lùi ra xa

        Vector3 desiredPos = target.position + dynamicOffset;

        transform.position = Vector3.Lerp(
            transform.position,
            desiredPos,
            Time.deltaTime * followSpeed
        );

        transform.LookAt(target);
    }
}