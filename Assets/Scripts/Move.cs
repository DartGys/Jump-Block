using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool moveByTouch, gameState;
    private Vector3 mouseStartPos, playerStartPos;
    private Camera camera;
    private int spawnCheck = 20;
    public float strafeSpeed;
    public float forwardSpeed = 10f;
    bool gameStartCheck = false;
    void Start()
    {
        camera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) gameStartCheck = true;
        if (gameStartCheck)
        {
            MoveThePlayer();
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
            if (gameObject.transform.position.z > spawnCheck)
            {
                staticBoleans.spawnGround = true;
                spawnCheck += 30;
            }

        }
    }


    void MoveThePlayer()
    {
        if (Input.GetMouseButtonDown(0) && gameState)
        {
            moveByTouch = true;

            var plane = new Plane(Vector3.up, 0f);

            var ray = camera.ScreenPointToRay(Input.mousePosition);

            if (plane.Raycast(ray, out var distance))
            {
                mouseStartPos = ray.GetPoint(distance + 1f);
                playerStartPos = transform.position;
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            moveByTouch = false;
        }

        if (moveByTouch)
        {
            var plane = new Plane(Vector3.up, 0f);
            var ray = camera.ScreenPointToRay(Input.mousePosition);

            if (plane.Raycast(ray, out var distance))
            {
                var mousePos = ray.GetPoint(distance + 1f);
                var move = mousePos - mouseStartPos;
                var control = playerStartPos + move;
                control.x = Mathf.Clamp(control.x, -2f, 2f);

                transform.position = new Vector3(Mathf.Lerp(transform.position.x, control.x, Time.deltaTime * strafeSpeed)
                    , transform.position.y, transform.position.z);

            }
        }
    }
}
