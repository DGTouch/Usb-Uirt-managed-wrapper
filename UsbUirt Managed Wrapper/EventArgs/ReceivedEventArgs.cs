namespace UsbUirt.EventArgs
{
	/// <summary>
	/// Event args passed to the Received event.
	/// </summary>
	public class ReceivedEventArgs : System.EventArgs
	{
		private string _irCode;

		internal ReceivedEventArgs(string irCode)
		{
			_irCode = irCode;
		}

		/// <summary>
		/// Gets the received IR code.
		/// </summary>
		public string IRCode 
		{
			get 
			{
				return _irCode; 
			}
		}
	}
}
