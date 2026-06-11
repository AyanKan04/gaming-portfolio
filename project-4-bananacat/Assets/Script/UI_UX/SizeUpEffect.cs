using System.Collections;
using UnityEngine;

public class SizeUpEffect : MonoBehaviour
{
    private CanvasGroup cg;
    private RectTransform rect;
    private Vector3 originalLocalPos;

    void Awake()
    {
        cg = GetComponent<CanvasGroup>();
        rect = GetComponent<RectTransform>();
        originalLocalPos = rect.localPosition;
        cg.alpha = 0;
    }

    void Update()
    {
        // Luôn xoay chữ hướng về Camera
        if (Camera.main != null && cg.alpha > 0)
        {
            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
                             Camera.main.transform.rotation * Vector3.up);
        }
    }

    public void Show()
    {
        StopAllCoroutines();
        StartCoroutine(PlayAnim());
    }

    IEnumerator PlayAnim()
    {
        cg.alpha = 1;
        rect.localScale = Vector3.zero;
        rect.localPosition = originalLocalPos; // Reset vị trí về trên đầu Player

        // 1. Nảy ra
        float t = 0;
        while (t < 1f)
        {
            t += Time.deltaTime * 8f;
            rect.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
            yield return null;
        }

        yield return new WaitForSeconds(1f);

        // 2. Bay lên và mờ dần trong không gian 3D
        t = 0;
        while (t < 1f)
        {
            t += Time.deltaTime * 2f;
            cg.alpha = 1 - t;
            // Bay lên theo trục Y thế giới
            rect.position += Vector3.up * 2f * Time.deltaTime;
            yield return null;
        }

        cg.alpha = 0;
        rect.localPosition = originalLocalPos; // Trả về vị trí ban đầu
    }
}