using UnityEngine;
using UnityEngine.EventSystems;

public class RightMoveUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private PlayerController player;

    private void Update()
    {
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        this.player.instance.isRight = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.player.instance.isRight = false;
    }
}
