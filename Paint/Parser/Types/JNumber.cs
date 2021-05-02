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
using System;
using Paint.Tokenizer;

namespace Paint.Parser
{
	public class JNumber : Value
	{
		Token token;
		public JNumber(Token token)
		{
			this.token = token;
		}

		public override string ToString()
		{
			return token.Value;
		}

		public override JSONMemberType getType()
		{
			return JSONMemberType.Number;
		}

		public override JNumber getNumber()
		{
			return this;
		}

		public override string Indent(uint indentation = 0)
		{
			return this.ToString();
		}

		public override Value ConsoleColorization(int indentation = 0)
		{
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.Write(this);
			Console.ResetColor();
			return this;
		}
	}
}