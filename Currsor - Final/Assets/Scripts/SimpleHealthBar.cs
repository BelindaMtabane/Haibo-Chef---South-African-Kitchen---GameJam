using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class SimpleHealthBar : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float maxHP = 100f;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private float minDamage = 10f;
    [SerializeField] private float maxDamage = 20f;

    [Header("Optional Hooks")]
    [SerializeField] private UnityEvent<float> onSpeedChange;

    private float currentHP;

    public float CurrentHP => currentHP;
    public float MaxHP => maxHP;

    private void Start()
    {
        currentHP = maxHP;
        RefreshUI();
    }

    public void DamageTaker(float damager)
    {
        currentHP = Mathf.Max(0f, currentHP - damager);
        RefreshUI();
        Death();
    }

    public void HealthIntaker(int healthPickup)
    {
        currentHP = Mathf.Min(maxHP, currentHP + healthPickup);
        RefreshUI();
    }

    private void Death()
    {
        if (currentHP <= 0f)
        {
            Debug.Log("Player died!");
        }
    }

    private void RefreshUI()
    {
        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHP;
            healthSlider.value = currentHP;
        }

        if (healthText != null)
        {
            healthText.text = $"Health: {Mathf.CeilToInt(currentHP)}";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("health"))
        {
            HealthIntaker(10);
            return;
        }

        if (collision.gameObject.CompareTag("speed"))
        {
            onSpeedChange?.Invoke(10f);
            return;
        }

        if (collision.gameObject.CompareTag("Obstacle1"))
        {
            float damage = Random.Range(minDamage, maxDamage);
            DamageTaker(damage);
            return;
        }

        if (collision.gameObject.CompareTag("Obstacle2"))
        {
            onSpeedChange?.Invoke(-15f);
        }
    }
}
