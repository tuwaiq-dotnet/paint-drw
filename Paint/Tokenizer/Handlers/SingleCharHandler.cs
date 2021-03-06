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
using System.Collections.Generic;

namespace Paint.Tokenizer
{
	public class SingleCharHandler : Tokenizable
	{
		private List<Char> jsonCharacters = new List<Char>{',', ':', '{', '}', '[', ']'};
		public override bool tokenizable(Input input)
		{
			return this.jsonCharacters.Contains(input.peek());
		}

		public override Token tokenize(Input input)
		{
			int initPos = input.Position;
			int ln = input.LineNumber;
			char val = input.step().Character;
			switch (val)
			{
				case ',':
					return new Token(input.Position, input.LineNumber, TokenType.Comma, "" + val);
				case ':':
					return new Token(input.Position, input.LineNumber, TokenType.Colon, "" + val);
				case '{':
					return new Token(input.Position, input.LineNumber, TokenType.OpeningCurlyBracket, "" + val);
				case '}':
					return new Token(input.Position, input.LineNumber, TokenType.ClosingCurlyBracket, "" + val);
				case '[':
					return new Token(input.Position, input.LineNumber, TokenType.OpeningBracket, "" + val);
				case ']':
					return new Token(input.Position, input.LineNumber, TokenType.ClosingBracket, "" + val);
			}

			throw new Exception($"Unexpected Token at Ln {ln} Col {initPos + 1}");
		}
	}
}