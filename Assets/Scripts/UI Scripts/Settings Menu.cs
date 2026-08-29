using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Movement Player1;
    [SerializeField] private Movement Player2;

    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private Button btnBack;
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;

    private void Awake()
    {
        btnBack.onClick.AddListener(OnBackClicked);
        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnDestroy()
    {
        btnBack.onClick.RemoveAllListeners();
        btnBack.onClick.RemoveAllListeners();
        btnBack.onClick.RemoveAllListeners();
        sliderPlayer1Speed.onValueChanged.RemoveAllListeners();
        sliderPlayer2Speed.onValueChanged.RemoveAllListeners();
    }

    // Custom Functions
    private void OnBackClicked()
    {

    }

    private void OnPlayer1SpeedChanged(float value)
    {
        Player1.Speed = value;
    }
    private void OnPlayer2SpeedChanged(float value)
    {
        Player2.Speed = value;
    }

}
