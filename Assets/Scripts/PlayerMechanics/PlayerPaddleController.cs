using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
  public string movementAxisName = "Vertical";
  public float speed = 5f;
  public bool isPlayer01 = false;

  public SpriteRenderer spriteRenderer;

    void Start()
    {
      if (isPlayer01)
        spriteRenderer.color = SaveController.Instance.player01Color;
      else
        spriteRenderer.color = SaveController.Instance.player02Color;
    }

    void Update()
    {
        //movimento das raquetes.
       float moveInput = Input.GetAxis(movementAxisName);
       Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;
       newPosition.y = Mathf.Clamp(newPosition.y, -3.8f, 5.8f);

       transform.position = newPosition;
    }
}
