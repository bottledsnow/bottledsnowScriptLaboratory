using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float addForce;
    public int Damage;
    public int AllDamage;

    public float Horizontal;
    public float Vertical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerInput();
        playerController();
    }

    private void PlayerInput()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
    }

    private void playerController()
    {
        Vector3 playerDirection = new Vector3(Horizontal, 0, Vertical);
        rb.velocity = playerDirection * addForce;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Enemy")
        {
            IHealth health = collision.gameObject.GetComponent<IHealth>();
            health.TakeDamage(Damage);
            AllDamage -= Damage - health.Defense;
            Debug.Log("We Deal" + AllDamage + " points of damage to the all enemy");
            Debug.Log("Enemy Health=" + health.Health);
        }
    }
}
