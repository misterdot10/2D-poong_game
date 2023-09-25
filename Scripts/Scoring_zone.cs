//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Scoring_zone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoretriger;
    public float BounceStrange;
    private void OnCollisionEnter2D(Collision2D collision){
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null){
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoretriger.Invoke(eventData);
        }
    }
}
