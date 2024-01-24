using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SwipeDetection : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public float duration = 0.25f;

	// �X���C�v�Ƃ��ĔF�������̂ɕK�v�ƂȂ�h���b�O�̍Œ዗��
	public float threshold = 200;

	// ���E�̃X���C�v�ɑ΂��锽�����g���K�[����C�x���g
	public UnityEvent onSwipeRight;
	public UnityEvent onSwipeLeft;

	// �h���b�O�̊J�n���Ԃ�ێ�
	public float startTime;

	// �h���b�O�̊J�n�ʒu�ƏI���ʒu�̍�
	public Vector2 delta;


	public void OnBeginDrag(PointerEventData eventData)
	{
		// �N���b�N�������Ԃ�������
		startTime = Time.time;

		// �^���̕ω���delta��������
		delta = new Vector2();

	}

	public void OnDrag(PointerEventData eventData)
	{
		// �^���̕ω���delta���X�V 
		delta += eventData.delta;

	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if ((Time.time - startTime) > duration)
		{
			return;
		}

		if (Mathf.Abs(delta.x) > threshold)
		{
			if (delta.x > 0)
			{
				onSwipeRight?.Invoke();
			}
			else
			{
				onSwipeLeft?.Invoke();
			}
		}
	}
}

