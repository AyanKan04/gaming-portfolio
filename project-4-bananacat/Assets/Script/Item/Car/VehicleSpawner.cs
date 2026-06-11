using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public enum SpawnDirection { Up, Down, Left, Right }

    [Header("Settings")]
    [SerializeField] private GameObject[] vehiclePrefabs; // Danh sách các loại xe
    [SerializeField] private float spawnInterval = 3f;    // x giây sinh 1 lần
    [SerializeField] private float moveSpeed = 10f;       // Tốc độ xe
    [SerializeField] private float vehicleLifeTime = 10f; // Thời gian tồn tại trước khi hủy
    [SerializeField] private SpawnDirection directionType; // Hướng chạy

    private float timer;
    private Vector3 moveDir;

    void Start()
    {
        // Xác định Vector hướng dựa trên enum
        switch (directionType)
        {
            case SpawnDirection.Up: moveDir = Vector3.forward; break;
            case SpawnDirection.Down: moveDir = Vector3.back; break;
            case SpawnDirection.Left: moveDir = Vector3.left; break;
            case SpawnDirection.Right: moveDir = Vector3.right; break;
        }

        // Sinh xe ngay lập tức khi bắt đầu
        SpawnVehicle();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnVehicle();
            timer = 0f;
        }
    }

    void SpawnVehicle()
    {
        if (vehiclePrefabs.Length == 0) return;

        // Chọn ngẫu nhiên 1 prefab xe
        GameObject randomVehicle = vehiclePrefabs[Random.Range(0, vehiclePrefabs.Length)];

        // Tạo xe tại vị trí của Spawner
        GameObject newVehicle = Instantiate(randomVehicle, transform.position, Quaternion.identity);

        // Gắn script di chuyển và truyền thông số
        VehicleMove moveScript = newVehicle.GetComponent<VehicleMove>();
        if (moveScript == null) moveScript = newVehicle.AddComponent<VehicleMove>();

        moveScript.Setup(moveSpeed, vehicleLifeTime, moveDir);
    }

    // Vẽ mũi tên trong Editor để dễ phân biệt hướng spawn
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Vector3 debugDir = Vector3.forward;
        switch (directionType)
        {
            case SpawnDirection.Up: debugDir = Vector3.forward; break;
            case SpawnDirection.Down: debugDir = Vector3.back; break;
            case SpawnDirection.Left: debugDir = Vector3.left; break;
            case SpawnDirection.Right: debugDir = Vector3.right; break;
        }
        Gizmos.DrawRay(transform.position, debugDir * 2f);
    }
}