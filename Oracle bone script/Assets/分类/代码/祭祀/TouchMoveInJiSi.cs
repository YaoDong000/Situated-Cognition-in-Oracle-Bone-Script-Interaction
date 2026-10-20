using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchMoveInJiSi : MonoBehaviour, IPointerDownHandler
{
    private RectTransform rect;
    public RectTransform targetRect;
    public GameObject TiHuan;
    private Vector2 initPos;
    private bool isClick;
    public GameObject JiJuTiShi;

    public float interval = 2.0f;
    [SerializeField]

//    private bool isPointDown = false;
    UnityEvent m_OnLongpress = new UnityEvent();

    private float lastInvokeTime;


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
            if (Time.time - lastInvokeTime > interval)
            {
                //触发点击;    
                m_OnLongpress.Invoke();
                lastInvokeTime = Time.time;
                rect.position = Input.mousePosition;
                Debug.Log("长按");
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            TouchUp();
        }

        if (Input.GetTouch(0).phase == TouchPhase.Moved && isClick)
        {
            rect.position = Input.GetTouch(0).position;
        }
        if (Input.GetTouch(0).phase == TouchPhase.Canceled)
        {
            TouchUp();
        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        m_OnLongpress.Invoke();
//        isPointDown = true;
        isClick = true;
        lastInvokeTime = Time.time;
        Debug.Log("鼠标按下");
    }


   

    
    private void TouchUp()
    {
        //isPointDown = false;
        isClick = false;
        Debug.Log("鼠标抬起");
        if (CheckMoveToTarget())
        {
            //TODO拖到目标时的处理
            Debug.Log(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            TiHuan.SetActive(true);
            JiJuTiShi.SetActive(false);
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