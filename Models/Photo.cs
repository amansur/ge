using System;

namespace georgia 
{
	public class Photo
	{
		public int Id { get; set; }
		public string Slug { get; set; }
		public Guid PhotoUid { get; set; }
		public string FilePath { get; set; }
		public byte[] Binary { get; set; }
		public string FileEnding { get; set; }
	}

}