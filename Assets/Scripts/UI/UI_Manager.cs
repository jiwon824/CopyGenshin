using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI_Manager : MonoBehaviour
{
    [Header("Game UI")]
    public GameObject game_leftTop_Pannel;
    public GameObject game_rightTop_Pannel;
    public GameObject game_rightbottom_Pannel;
    public GameObject game_centerbottom_Pannel;
    [Space]



    [Header("Menu UI")]
    public GameObject menu_Pannel;


    bool isGameUIHide; // esc로 UI-> Menu / Menu ->UI 이렇게 왔다갔다 해야해서 필요함

    void Start()
    {
		Cursor.lockState = CursorLockMode.Locked;
		isGameUIHide = false;
	}

    void Update()
    {
        // if key down left alt, you can see cursor
        if(Input.GetKey(KeyCode.LeftAlt)) Cursor.lockState = CursorLockMode.None;
		else Cursor.lockState = CursorLockMode.Locked;

        // esc
        if (isGameUIHide && Input.GetKeyDown(KeyCode.Escape))
        {
            ShowGameUI();
        }
        else if (!isGameUIHide && Input.GetKeyDown(KeyCode.Escape))
        {
            HideGameUI();
        }

	}

    public void HideGameUI()
    {
        Debug.Log("HideGameUI");
        isGameUIHide = true;
		game_leftTop_Pannel.GetComponent<RectTransform>().DOLocalMoveY(1000f, 0.5f);
		game_rightTop_Pannel.GetComponent<RectTransform>().DOLocalMoveY(1000f, 0.5f);
		game_rightbottom_Pannel.GetComponent<RectTransform>().DOLocalMoveY(-1000f, 0.5f);
		game_centerbottom_Pannel.GetComponent<RectTransform>().DOLocalMoveY(-1000f, 0.5f);
    }

    public void ShowGameUI()
    {
        Debug.Log("ShowGameUI");
        isGameUIHide = false;
		game_leftTop_Pannel.GetComponent<RectTransform>().DOLocalMoveY(350f, 0.5f);
		game_rightTop_Pannel.GetComponent<RectTransform>().DOLocalMoveY(550f, 0.5f);
		game_rightbottom_Pannel.GetComponent<RectTransform>().DOLocalMoveY(-500f, 0.5f);
		game_centerbottom_Pannel.GetComponent<RectTransform>().DOLocalMoveY(-500f, 0.5f);
	}



	#region OnClick Btn Methods
	public void OnClick_Menu()
    {
        HideGameUI();
	}
    public void OnClick_BackBtn()
    {

    }

	public void OnClick_Quest()
    {
        HideGameUI();
    }
    public void OnClick_Map()
    {
        HideGameUI();

    }


    public void OnClick_Character()
    {
        HideGameUI();

    }
    public void OnClick_Inventory()
    {
        HideGameUI();

    }
    public void OnClick_Guide()
    {
        HideGameUI();

    }
    public void OnClick_Gemble()
    {
        HideGameUI();

    }
    public void OnClick_BattlePass()
    {
        HideGameUI();

    }
    public void OnClick_Event()
    {
        HideGameUI();

    }
	#endregion
}
