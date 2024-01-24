using UnityEngine;

public class DebugTool : MonoBehaviour
{

	// �v���C���[�̔N���\��
	public void PrintPlayerAge()
	{
		Debug.Log(PlayerManager.Instance.playerAge);
	}



	// �C���X�^���X���Z�b�g�A�b�v
	public void PrintPlayerName()
	{
		Debug.Log(PlayerManager.Instance.playerName);
	}

	// �N�����̃C���X�^���X�̐ݒ�
	public void OnEnable()
	{
		PlayerManager.Instance.nameUpdated.AddListener(PrintPlayerName);
	}

	// ��~���̃C���X�^���X�̐ݒ�
	public void OnDisable()
	{
		PlayerManager.Instance.nameUpdated.RemoveListener(PrintPlayerName);
	}
}
