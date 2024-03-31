using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private VariableJoystick variableJoystick;
    private bool isJoystick;
    private CharacterController controller;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private Animator playerAnimation;
    public float health;
    public int diamondCount;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        EnableJoystick();
    }

    // Update is called once per frame
    void Update()
    {
        if (isJoystick)
        {
            var direction = new Vector3(variableJoystick.Direction.x, 0.0f, variableJoystick.Direction.y);
            controller.SimpleMove(direction * speed);
            if (direction.sqrMagnitude <= 0)
            {
                playerAnimation.SetBool("Run", false);
                return;
            }
            playerAnimation.SetBool("Run", true);
            var targetDirection = Vector3.RotateTowards(controller.transform.forward, direction,rotationSpeed*Time.deltaTime,0f);
            controller.transform.rotation = Quaternion.LookRotation(targetDirection);
        }
        
    }
    public void EnableJoystick()
    {
        isJoystick = true;
        canvas.gameObject.SetActive(true);
    }
    private void LateUpdate()
    {
        transform.GetChild(1).transform.rotation = Quaternion.identity;
    }
}
