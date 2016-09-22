using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DragPanel : MonoBehaviour
{
    /*
    private Vector2 pointerOffSet;
    private RectTrasnform canvasRectTransform;
    private RectTrasnform panelRectTransform;

    void Aweak ()
    {
        Canvas canvas = GetComponentInParent<Canvas>();
        if (Canvas != null)
        {
            canvasRectTransform = canvas.transform as RectTransform;
            panelRectTransform = transform as RectTransform;
        }
    }

    public void OnPointerDown(pointerEventData data)
    {
        panelRectTransform.SetAsLastSibling();
        RectTrasnformUtility.ScreenPointToLocalPointInRectangle(panelRectTransform, data.position, data.pressEventCamera, out pointerOffSet);
    }

    public void OnDrag(PointerEventData data)
    {
        if (panelRectTransform == null)
        {
            return;
        }

        Vector2 localPointerPosition;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, data.position, data.pressEventCamera, out localPointerPosition))
        {
            panelRectTransform.localPosition = localPointerPosition - pointerOffSet;
        }
    }
    */
}
