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
namespace Paint.Tokenizer
{
	public abstract class Tokenizable
	{
		public abstract bool tokenizable(Input input);
		public abstract Token tokenize(Input input);
	}
}