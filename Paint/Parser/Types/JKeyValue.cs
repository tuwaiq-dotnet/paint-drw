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
using Paint.Tokenizer;
namespace Paint.Parser
{
	public class JKeyValue
	{
		public Token key;
		public Value value;
		public JKeyValue(Token key, Value value)
		{
			this.key = key;
			this.value = value;
		}

		public override string ToString()
		{
			// return $@"{this.key}: {this.value}";
			return $"{this.key}:{this.value}";
		}
	}
}