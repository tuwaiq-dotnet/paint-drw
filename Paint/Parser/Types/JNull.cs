/*
 * Tuwaiq .NET Bootcamp | Paint
 * 
 * Team Members
 * 
 * Abdulrahman Bin Maneea
 * Younes Alturkey
 * Anas Alhmoud
 * Faisal Alsagri
 * 
 */
using System;using Paint.Tokenizer;

namespace Paint.Parser
{
	public class JNull : Value
	{
		Token token;
		public JNull(Token token)
		{
			this.token = token;
		}

		public override JNull getNull()
		{
			return this;
		}

		public override JSONMemberType getType()
		{
			return JSONMemberType.Null;
		}

		public override string ToString()
		{
			return "null";
		}

		public override string Indent(uint indentation = 0)
		{
			return this.ToString();
		}

		public override Value ConsoleColorization(int indentation = 0)
		{
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write(this);
			Console.ResetColor();
			return this;
		}
	}
}