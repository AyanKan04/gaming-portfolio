using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // THÊM 2 BIẾN NÀY ĐỂ HẾT LỖI
    [Header("Tutorial")]
    [SerializeField] private GameObject tutorialHand; // Kéo object bàn tay vào đây
    private bool timerStarted = false; // Trạng thái đã bắt đầu game chưa

    [Header("Movement")]
    [SerializeField] private Joystick movementJoystick;
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody rb;

    [Header("Collect & Level")]
    [SerializeField] private float radius = 3f;
    [SerializeField] private float pullSpeed = 10f;
    [SerializeField] private int[] expTable = { 30, 100, 300, 2000, 5000, 12000, 25000, 50000 };

    [Header("Links")]
    [SerializeField] private CharacterAnimations anim;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private GameObject scorePopupPrefab;
    [SerializeField] private SizeUpEffect sizeUpVisual;

    private int level, exp, expToNext;
    private bool canMove = true;
    private Vector3 moveInput;

    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
        expToNext = expTable[0];
        uiManager.UpdateUI(level, exp, expToNext);

        // Đảm bảo bàn tay hiện lên lúc đầu
        if (tutorialHand != null) tutorialHand.SetActive(true);
    }

    void Update()
    {
        // LOGIC TUTORIAL: Nếu chưa chạm màn hình lần đầu thì dừng tại đây
        if (!timerStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                timerStarted = true;
                if (tutorialHand != null) tutorialHand.SetActive(false); // Tắt bàn tay
            }
            return;
        }

        // Sau khi chạm lần đầu, game mới chạy logic di chuyển
        moveInput = new Vector3(movementJoystick.joystickVec.x, 0, movementJoystick.joystickVec.y);
        anim.SetBool("isWalk", moveInput.sqrMagnitude > 0.01f);
    }

    void FixedUpdate()
    {
        // Chặn di chuyển nếu chưa bắt đầu game HOẶC bị khóa di chuyển
        if (!timerStarted || !canMove)
        {
            rb.velocity = Vector3.zero;
            anim.SetBool("isWalk", false);
            return;
        }

        rb.velocity = Vector3.Lerp(rb.velocity, moveInput * speed, Time.fixedDeltaTime * 10f);
        if (moveInput.sqrMagnitude > 0.01f) transform.forward = moveInput;

        // Logic hút Item
        Collider[] hits = Physics.OverlapSphere(transform.position, radius);
        foreach (var hit in hits)
        {
            if (!hit.CompareTag("Item")) continue;
            Item item = hit.GetComponent<Item>();
            if (item == null || level < item.GetRequiredLevel()) continue;

            float dist = Vector3.Distance(hit.transform.position, transform.position);
            hit.transform.position = Vector3.MoveTowards(hit.transform.position, transform.position, pullSpeed * Time.fixedDeltaTime);
            hit.transform.localScale = item.GetOriginalScale() * Mathf.Clamp(dist / radius, 0.2f, 1f);

            if (dist < 0.5f) EatItem(item, hit.gameObject);
        }
    }

   
    void EatItem(Item item, GameObject obj)
    {
        SimpleAudioManager.instance.PlayEat();
        int val = item.GetValue();
        exp += val;
        ShowScorePopup(obj.transform.position, val);
        Destroy(obj);
        CheckLevelUp();
    }

    void CheckLevelUp()
    {
        bool leveled = false;
        while (level < expTable.Length && exp >= expToNext)
        {
            exp -= expToNext;
            level++;
            leveled = true;
            radius += level;
            pullSpeed += level * 0.5f;
            speed += level * 3;

            float scaleMult = 1.25f + Mathf.Log(level + 1) * 0.4f;
            transform.localScale = Vector3.Min(transform.localScale * scaleMult, Vector3.one * 30f);
            if (level < expTable.Length) expToNext = expTable[level];
        }

        if (leveled)
        {
            StartCoroutine(ScalePunch());
            if (sizeUpVisual != null) sizeUpVisual.Show();
            SimpleAudioManager.instance.PlayLevelUp();
        }
        uiManager.UpdateUI(level, exp, expToNext);
    }

    private void ShowScorePopup(Vector3 pos, int val)
    {
        if (scorePopupPrefab == null) return;
        GameObject pop = Instantiate(scorePopupPrefab, pos, Quaternion.identity);
        pop.GetComponent<FloatingText>().Initialize("+" + val, val >= 100 ? Color.red : Color.white, transform.localScale);
    }

    IEnumerator ScalePunch()
    {
        Vector3 orig = transform.localScale;
        transform.localScale = orig * 1.2f;
        yield return new WaitForSeconds(0.1f);
        transform.localScale = orig;
    }

    public void SetCanMove(bool val)
    {
        canMove = val;
        if (!val) rb.velocity = Vector3.zero;
    }
}