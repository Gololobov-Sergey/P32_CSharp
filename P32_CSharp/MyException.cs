using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{

	[Serializable]
	public class ErrorException : Exception
	{
		public ErrorException() 
		{
			Data.Add("Date", DateTime.Now);
			Data.Add("Programmer", "Gololobov SA");
		}
		public ErrorException(string message) : base(message) { }
		public ErrorException(string message, Exception inner) : base(message, inner) { }
		protected ErrorException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}


	public class Garbage
	{
		public void MakeGarbage()
		{
			for(int i = 0; i < 1000; i++)
			{
				Student student = new Student();	
			}
		}
	}
}
