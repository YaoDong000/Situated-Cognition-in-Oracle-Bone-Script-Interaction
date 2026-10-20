using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchMove : MonoBehaviour, IPointerDownHandler
{
    

    private RectTransform rect;
    public RectTransform targetRect;

    private Vector2 initPos;
    private bool isClick;
    public GameObject MoBan;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        initPos = rect.position;
    }

    public void Restore()
    {
        rect.position = initPos;
    }

    void Update()
    {

        if (Input.GetMouseButton(0) && isClick)
        {
            rect.position = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            TouchUp();
        }
       /* if (Input.GetTouch(0).phase == TouchPhase.Moved && isClick)
        {
            rect.position = Input.GetTouch(0).position;
        }
        if (Input.GetTouch(0).phase == TouchPhase.Canceled)
        {
            TouchUp();
        }
        */

    }


    public void OnPointerDown(PointerEventData eventData)
    {
        isClick = true;
    }

    private void TouchUp()
    {
        isClick = false;
        if (CheckMoveToTarget())
        {
            //TODO拖到目标时的处理
            Debug.Log(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            MoBan.GetComponent<Image>().enabled = true;
            Destroy(gameObject, 0f);
        }
        else
        {
            Restore();
        }
    }

    /// <summary>
    /// 检测是否拖动到目标
    /// </summary>
    /// <returns></returns>
    private bool CheckMoveToTarget()
    {
        return RectTransformUtility.RectangleContainsScreenPoint(targetRect, rect.position);
    }
}