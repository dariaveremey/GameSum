using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MagicNumbers2 : MonoBehaviour
{
    public TextMeshProUGUI StartLabel;
    public TextMeshProUGUI SumLabel;
    public TextMeshProUGUI CountLabel;

    public delegate void Restart(int time);
    public delegate int PauseTime();
    
    private int _sum;
    private int _endgame = 50;
    private int _counter = 0;
        
        
    private void Options()
    {
        _sum = 0;
        _counter = 0;
        SetStartText($"Добро пожаловать в игру!");
    }
        
    void Start()
    {
        Options();
    }

    private void InfoUp()
    {
        SetSumText($"Моя сумма {_sum}");
        Counter();
        SetCountText($"Число ходов: {_counter}");
    }
        
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && _sum < _endgame)
        {
            _sum++;
            InfoUp();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && _sum < _endgame)
        {
            _sum=_sum+2; 
            InfoUp();
        }         
        else if (Input.GetKeyDown(KeyCode.Alpha3) && _sum < _endgame)
        {
            _sum=_sum+3;
            InfoUp();
        }        
        else if (Input.GetKeyDown(KeyCode.Alpha4) && _sum < _endgame)
        {
            _sum=_sum+4;
            InfoUp();
        }     
        else if (Input.GetKeyDown(KeyCode.Alpha5) && _sum < _endgame)
        {
            _sum=_sum+5;
            InfoUp();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) && _sum < _endgame)
        {
            _sum=_sum+5;
            InfoUp();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) && _sum < _endgame)
        {
            _sum=_sum+6;
            InfoUp();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) && _sum < _endgame)
        {
            _sum=_sum+7;
            InfoUp();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) && _sum < _endgame)
        {
            _sum=_sum+8;
            InfoUp();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) && _sum < _endgame)
        {
            _sum=_sum+9;
            InfoUp();
        }
        else if (_sum > _endgame)
        {
            SetStartText("Вы проиграли!");
            SetSumText($"Моя сумма {_sum}");
            SetCountText($"Число ходов: {_counter}");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Options();
            SetSumText($"Моя сумма {_sum}");
            SetCountText($"Число ходов: {_counter}");
        }

    }
    
        private void Counter()
        {
            _counter++;
        }
        
        private void SetStartText(string text)
        {
            StartLabel.text = text;
        }
    
        private void SetSumText(string text)
        {
            SumLabel.text = text;
        }    
        
        private void SetCountText(string text)
        {
            CountLabel.text = text;
        }
        
        
}
