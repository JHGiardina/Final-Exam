using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float health = 100f;

    public float attackTimer = 3f;

    public int attackDamage = 5;
    private float cTime;
    Slider slider;
    TextMeshProUGUI tmp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponentInChildren<Slider>();
        tmp = GetComponentInChildren<TextMeshProUGUI>();
        cTime = 0;
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {

        if(health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        cTime += Time.deltaTime;
        if (cTime >= attackTimer){
            health -= attackDamage;
            cTime = 0;
            UpdateHealth();
        }

    }

    void UpdateHealth(){
        slider.value = health;
        string _sHealth = health.ToString();
        tmp.SetText(_sHealth);
    }

}
