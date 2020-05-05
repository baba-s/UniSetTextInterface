namespace UniSetTextInterface
{
	/// <summary>
	/// テキストを設定できるインターフェイス
	/// </summary>
	public interface ITextSetter
	{
		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// テキストを設定します
		/// </summary>
		void SetText( string text );
	}
}