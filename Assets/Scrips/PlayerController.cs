using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float minX = -7f;  // Valor mínimo no eixo X
    private float maxX = 9.84f;  // Valor máximo no eixo X

    // Update is called once per frame
    void Update()
    {
        MoveBucket(); // Chama a função para mover o balde no Update
    }

    void MoveBucket()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalMovement, 0f, 0f);

        // Move o balde
        transform.Translate(movement * speed * Time.deltaTime);

        // Limita a posição do balde no eixo X
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }

    // Função para alterar a velocidade do balde
    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
