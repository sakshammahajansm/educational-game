using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text textComponent;
    public float scrollSpeed;

    private RectTransform m_textRecttransform;

    private Text m_CloneTextObject;
    private RectTransform m_textRectTransform;


    // Start is called before the first frame update
    void Awake()
    {
        m_textRecttransform = textComponent.GetComponent<RectTransform>();
        // m_CloneTextObject = Instantiate(textComponent) as Text;
        // RectTransform cloneRectTransform = m_CloneTextObject.GetComponent<RectTransform>();
        // cloneRectTransform.SetParent(m_textRecttransform);
        // cloneRectTransform.anchoredPosition = new Vector2(0, 0);
        // cloneRectTransform.anchorMin = new Vector2(1.0f, 0.5f);
        // cloneRectTransform.localScale = Vector3.one;
    }

    IEnumerator Start()
    {
        float width = textComponent.preferredWidth;
        Vector3 startPosition = m_textRecttransform.position;

        float scrollPosition = 0;
        Debug.Log("Width" + width);

        while (true)
        {
            float remaider = scrollPosition % width;
            m_textRecttransform.anchoredPosition = new Vector3(-remaider, 0);

            scrollPosition += scrollSpeed * 20 * Time.deltaTime;

            yield return null;
        }

    }

}
