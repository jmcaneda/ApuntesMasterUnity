using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController : MonoBehaviour
{
    float startTime;
    float endTime;
    public int tapCounter = 0;
    public bool isDoubleTouch = false;
    public bool isSingleTouch = false;
    public Ray ray;
    private void LateUpdate()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startTime = Time.time;
                ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                //Debug.Log("startTime: " + Time.time.ToString() + "s");
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endTime = Time.time;
                //Debug.Log("endTime: " + Time.time.ToString() + "s");
            }
            if (endTime - startTime < 0.2f && endTime - startTime > 0f)
            {
                tapCounter++;
                if (tapCounter == 1)
                {
                    isSingleTouch = true;
                } else if (tapCounter == 2)
                {
                    isSingleTouch = false;
                    isDoubleTouch = true;
                }
                endTime = 0f;
                startTime = 0f;
                StartCoroutine(CountDown());
                Debug.Log("Tap counter: " + tapCounter);
            }
        }
        
        IEnumerator CountDown()
        {
            yield return new WaitForSeconds(0.7f);
            tapCounter = 0;
        }
    }
}
