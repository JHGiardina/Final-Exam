using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public int eHealth = 200;
    private Slider slider;
    private TextMeshProUGUI tmp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponentInChildren<Slider>();
        tmp = GetComponentInChildren<TextMeshProUGUI>();
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {

        if(eHealth <= 0)
        {
            SceneManager.LoadScene("YouWin");
        }

    if(Input.GetKeyDown(KeyCode.Space)){
        eHealth -= 1;
        UpdateHealth();
    }
    }

    void UpdateHealth(){

        slider.value = eHealth;

        string _sHealth = eHealth.ToString();
        tmp.SetText(_sHealth);
        
    }
}
