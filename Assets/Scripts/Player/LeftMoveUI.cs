using UnityEngine;
using UnityEngine.EventSystems;

public class LeftMoveUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private PlayerController player;

    private void Update()
    {
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        this.player.instance.isLeft = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.player.instance.isLeft = false;
    }
}
