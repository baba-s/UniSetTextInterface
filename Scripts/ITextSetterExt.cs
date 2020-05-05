using System.Text;

namespace UniSetTextInterface
{
	/// <summary>
	/// ITextSetter 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class ITextSetterExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, byte value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, short value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, int value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, long value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, ushort value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, uint value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, ulong value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, float value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, double value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, decimal value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, bool value )
		{
			self.SetText( value.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText( this ITextSetter self, StringBuilder sb )
		{
			self.SetText( sb.ToString() );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText<T>( this ITextSetter self, string format, T arg1 )
		{
			self.SetText( string.Format( format, arg1.ToString() ) );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText<T1, T2>( this ITextSetter self, string format, T1 arg1, T2 arg2 )
		{
			self.SetText( string.Format( format, arg1.ToString(), arg2.ToString() ) );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText<T1, T2, T3>( this ITextSetter self, string format, T1 arg1, T2 arg2, T3 arg3 )
		{
			self.SetText( string.Format( format, arg1.ToString(), arg2.ToString(), arg3.ToString() ) );
		}
		
		/// <summary>
		/// テキストを設定します
		/// </summary>
		public static void SetText<T1, T2, T3, T4>( this ITextSetter self, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4 )
		{
			self.SetText
			(
				string.Format
				(
					format, 
					arg1.ToString(), 
					arg2.ToString(), 
					arg3.ToString(),
					arg4.ToString()
				)
			);
		}
	}
}