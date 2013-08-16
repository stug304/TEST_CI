using System;

public class Class1
{
	public class MyAppContext : DbContext
    {
    public DbSet<Thing> Things { get; set; }
    public MyAppContext() : base("MyAppContext") { }
    }
}
