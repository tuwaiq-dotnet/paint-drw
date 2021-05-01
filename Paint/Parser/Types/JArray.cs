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
using System.Collections.Generic;
using System;using Paint.Tokenizer;

namespace Paint.Parser
{
	public class JArray : Value
	{
		new public uint Children
		{
			get
			{
				uint sum = 0;
				foreach (var item in Items)
					sum += item.Children;
				return sum;
			}
		}
		public int Count { get { return Items.Count; } }

		public List<Value> Items = new List<Value>();
		public override string ToString()
		{
			return $"[{string.Join(",", Items)}]";
		}

		public override JSONMemberType getType()
		{
			return JSONMemberType.Array;
		}

		public override JArray getArray()
		{
			return this;
		}

		public Value getItem(int i)
		{
			return this.Items.Count > i ? this.Items[i] : null;
		}

		public override string Indent(uint indentation = 0)
		{
			string ret = "[\n";
			foreach (var item in this.Items)
			{
				for (uint i = 0; i <= indentation + 1; i++)
					ret += '\t';
				ret += $"{item.Indent(indentation + 1)},\n";
			}

			if (ret.Length > 2)
			{
				ret = ret.Substring(0, ret.Length - 2) + "\n";
			}

			for (uint i = 0; i < indentation + 1; i++)
				ret += '\t';
			return ret + "]";
		}

		public override Value ConsoleColorization(int indentation = 0)
		{
			Console.ResetColor();
			Console.Write("[\n");
			int count = 0;
			foreach (var item in this.Items)
			{
				for (uint i = 0; i <= indentation + 1; i++)
					Console.Write('\t');
				item.ConsoleColorization(indentation + 1);
				if (++count == this.Items.Count)
					Console.Write("\n");
				else
					Console.Write(",\n");
			}

			// if (ret.Length > 2)
			// {
			//     ret = ret.Substring(0, ret.Length - 2) + "\n";
			// }
			for (uint i = 0; i < indentation + 1; i++)
				Console.Write('\t');
			Console.Write("]");
			Console.ResetColor();
			return this;
		}
	}
}