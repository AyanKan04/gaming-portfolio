using System.Collections.Generic;
using UnityEngine;

public class CameraOcclusion : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float fadeAlpha = 0.3f;
    [SerializeField] private float fadeSpeed = 10f;

    private HashSet<Renderer> fadedObjects = new HashSet<Renderer>();

    void LateUpdate()
    {
        Vector3 dir = target.position - transform.position;
        RaycastHit[] hits = Physics.RaycastAll(transform.position, dir.normalized, dir.magnitude);

        HashSet<Renderer> currentHits = new HashSet<Renderer>();

        foreach (var hit in hits)
        {
            if (hit.transform == target) continue;
            Renderer[] rends = hit.collider.GetComponentsInChildren<Renderer>();

            foreach (var r in rends)
            {
                currentHits.Add(r);
                ApplyFade(r, fadeAlpha);
                fadedObjects.Add(r);
            }
        }

        // Reset những object không còn bị Raycast đâm trúng
        fadedObjects.RemoveWhere(r => {
            if (r == null) return true;
            if (!currentHits.Contains(r))
            {
                ResetAlpha(r);
                return true;
            }
            return false;
        });
    }

    void ApplyFade(Renderer r, float alpha)
    {
        foreach (Material m in r.materials)
        {
            Color c = m.color;
            c.a = Mathf.Lerp(c.a, alpha, Time.deltaTime * fadeSpeed);
            m.color = c;
            SetupTransparent(m);
        }
    }

    void ResetAlpha(Renderer r)
    {
        foreach (Material m in r.materials)
        {
            Color c = m.color;
            c.a = 1f;
            m.color = c;
        }
    }

    void SetupTransparent(Material mat)
    {
        mat.SetFloat("_Mode", 2); // Chế độ Fade
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        mat.SetInt("_ZWrite", 0);
        mat.EnableKeyword("_ALPHABLEND_ON");
        mat.renderQueue = 3000;
    }
}