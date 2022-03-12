namespace SeconddTask
{
	public abstract class Share
	{
		public string Name { get; set; }

		protected Share(string name)
		{
			Name = name;
		}
	}
}
