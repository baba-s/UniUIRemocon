using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kogane.Internal
{
	[AddComponentMenu( "" )]
	[DisallowMultipleComponent]
	[RequireComponent( typeof( Button ), typeof( Image ) )]
	internal sealed class SelectButtonUI : MonoBehaviour
	{
		//==============================================================================
		// 変数(SerializeField)
		//==============================================================================
		[SerializeField] private Button m_buttonUI = default;
		[SerializeField] private Text   m_textUI   = default;
		[SerializeField] private Image  m_imageUI  = default;

		//==============================================================================
		// イベント
		//==============================================================================
		public Action mReleased
		{
			set
			{
				m_buttonUI.onClick.RemoveAllListeners();
				m_buttonUI.onClick.AddListener( () => value?.Invoke() );
			}
		}

		//==============================================================================
		// 関数
		//==============================================================================
		/// <summary>
		/// 選択されているかどうかを設定します
		/// </summary>
		public void SetIsSelected( bool isSelected )
		{
			m_imageUI.color = isSelected ? Color.yellow : Color.white;
		}

		/// <summary>
		/// テキストを設定します
		/// </summary>
		public void SetText( string text )
		{
			m_textUI.text = text;
		}
	}
}