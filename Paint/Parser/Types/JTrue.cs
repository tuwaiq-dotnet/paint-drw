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
	public class JTrue : Value
	{
		Token token;
		public JTrue(Token token)
		{
			this.token = token;
		}

		public override JTrue getTrue()
		{
			return this;
		}

		public bool getValue()
		{
			return true;
		}

		public override string ToString()
		{
			return "true";
		}

		public override JSONMemberType getType()
		{
			return JSONMemberType.True;
		}

		public override string Indent(uint indentation = 0)
		{
			return this.ToString();
		}

		public override Value ConsoleColorization(int indentation = 0)
		{
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(this);
			Console.ResetColor();
			return this;
		}
	}
}