using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour
{
    public RectTransform joystick;
    public RectTransform joystickBG;

    public Vector2 joystickVec;

    private Vector2 touchPos;
    private float radius;

    void Start()
    {
        radius = joystickBG.sizeDelta.y / 2f;

        //Ẩn lúc đầu
        joystick.gameObject.SetActive(false);
        joystickBG.gameObject.SetActive(false);
    }

    public void PointerDown(BaseEventData data)
    {
        PointerEventData ped = (PointerEventData)data;

        touchPos = ped.position;

        //hiện joystick tại vị trí chạm
        joystickBG.position = touchPos;
        joystick.position = touchPos;

        joystick.gameObject.SetActive(true);
        joystickBG.gameObject.SetActive(true);
    }

    public void Drag(BaseEventData data)
    {
        PointerEventData ped = (PointerEventData)data;
        Vector2 dragPos = ped.position;

        Vector2 dir = dragPos - touchPos;
        float dist = Mathf.Clamp(dir.magnitude, 0, radius);

        joystickVec = dir.normalized;

        joystick.position = touchPos + joystickVec * dist;
    }

    public void PointerUp(BaseEventData data)
    {
        joystickVec = Vector2.zero;

        //Ẩn lại khi thả
        joystick.gameObject.SetActive(false);
        joystickBG.gameObject.SetActive(false);
    }
}