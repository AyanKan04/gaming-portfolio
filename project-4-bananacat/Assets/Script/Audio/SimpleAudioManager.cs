using UnityEngine;

public class SimpleAudioManager : MonoBehaviour
{
    public static SimpleAudioManager instance;

    [Header("Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Clips")]
    [SerializeField] private AudioClip bgmClip;
    [SerializeField] private AudioClip eatClip;
    [SerializeField] private AudioClip levelUpClip;

    [Header("SFX Settings")]
    // TĂNG COOLDOWN LÊN: 0.12 đến 0.15 giây là con số vàng cho cơ chế hút item
    [SerializeField] private float eatCooldown = 0.12f;
    [Range(0, 1)][SerializeField] private float eatVolume = 0.6f;

    private float lastEatTime;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        musicSource.clip = bgmClip;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayEat()
    {
        // Nếu hút 10 item trong 0.1 giây, 
        // nó chỉ kêu đúng 1 tiếng cho item đầu tiên, 9 item sau bị bỏ qua tiếng.
        if (Time.time - lastEatTime < eatCooldown) return;

        lastEatTime = Time.time;

        sfxSource.pitch = Random.Range(0.85f, 1.2f);

        // Dùng PlayOneShot để tiếng Cà-nhông được phát ra trọn vẹn không bị cắt đuôi
        sfxSource.PlayOneShot(eatClip, eatVolume);
    }

    public void PlayLevelUp()
    {
        sfxSource.pitch = 1f;
        sfxSource.PlayOneShot(levelUpClip, 1f);
    }
}